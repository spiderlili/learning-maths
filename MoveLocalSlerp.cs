using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make the character turn slowly towards the target rather than snapping 
//using slerp(spherical linear interpolation) between the angle of the current facing vector and the angle of the goal facing vector over time


public class MoveLocalSlerp : MonoBehaviour {

	public Transform goal;
	float speed = 0.5f;
	float accuracy = 1.0f;
	float rotSpeed = 0.4f;

	void Start () {
		
	}
	

	void LateUpdate () {
		Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
		
		//work out the direction to face towards the goal vector
		Vector3 direction = lookAtGoal - this.transform.position;
		
		//snap to the right direction 
		//this.transform.LookAt(lookAtGoal);
		
		//using quarternion - a complex data structure holding a rotation - to do fantastic things
		//turning an angle from facing in one direction to another: takes the current character rotation, perform LookRotation on direction vector
		//LookRotation gives the rotation that needs to occur to be facing in the direction
		
		this.transform.rotation = Quarternion.Slerp(this.transform.rotation, Quarternion.LookRotation(direction), rotSpeed*Time.deltaTime);
		
		//if using applied root motion: remove the code below - related to pushing the character forward with animation rather than code
		if(Vector3.Distance(transform.position,lookAtGoal) > accuracy){
			this.transform.Translate(0,0,speed*Time.deltaTime);
			
		}
	}
}
