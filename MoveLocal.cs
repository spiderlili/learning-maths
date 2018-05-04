using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocal : MonoBehaviour {

	public Transform goal;
	float speed = 0.5f; //adjust according to the animation
	float accuracy = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		//change the direction to look for the enemy
		Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
		
		//rotating and orientating the model towards that direction regardless of where in 3d space the goal is positioned 
		this.transform.LookAt(lookAtGoal);
		if(Vector3.Distance(transform.position,lookAtGoal) > accuracy)
			//push the enemy along its z axis
			this.transform.Translate(0,0,speed*Time.deltaTime);
	}
}
