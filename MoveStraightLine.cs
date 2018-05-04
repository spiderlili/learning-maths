using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//moving objects without physics - most basic code for moving character in a straight line with consistent speed

public class MoveStraightLine : MonoBehaviour{
  
  //humanoid character - no floating in y direction, mobe along from any location
  public Vector3 goal = new Vector3(5,0,4); 
  public float speed = 0.1f;

  void Start(){
    //moving along at 10% of goal each time
    goal = goal * 0.01f;
  }
  
  //everytime Update runs: not necessarily at exactly the same time the last update happened => inconsistencies
  //any movement on characters - especially when adding character cameras for following things around: 
  //make it happen after all the physics has been calculated => LateUpdate() > Update()
  
  void LateUpdate(){
    //add the goal vector of unit length 1 onto the transform vector of the character - move at the same rate for different goal
    //smooth out and allow for the difference in the update running
    
    this.transform.Translate(goal.normalized * speed * Time.deltaTime);
  }
}
