using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//pushing the character forward while staying grounded - rotate in the direction of the object but only in xy plane
//the z axis lines up with the position of the object on a vertical axis from it at the exact same height of the character

public class MoveLocal : MonoBehaviour {

	public Transform goal;
	float speed = 0.5f; //adjust according to the animation
	float accuracy = 1.0f;

	void Start () {
		
	}
	
	void LateUpdate () {
		//change the direction to look for the enemy
		//the character performs a LookAt at the a point in the same Y as the character, but the same X anz Z as the object
		//create a new goal position to look at(lock the y axis to character height)
		this.transform.LookAt(lookAtGoal);
		Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
		
		//rotating and orientating the model towards that direction regardless of where in 3d space the goal is positioned 
		//so the z axis is pointing towards the position of the goal

		if(Vector3.Distance(transform.position,lookAtGoal) > accuracy)
			//push the enemy along its z axis
			this.transform.Translate(0,0,speed*Time.deltaTime);
	}
}
