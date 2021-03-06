using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//moving objects without physics - basic code for moving character in a straight line with consistent speed
//drive the goal object(player) with arrow keys and get the AI to follow it

public class MoveStraightLine : MonoBehaviour{
    
  public float speed = 1.0f; 
  public Transform goal; //set a position in the environment
  public float accurateDistToGoal = 0.2f; //accurate length vector from goal - stops jittering

  void Start(){

  }
  
  //everytime Update runs: not necessarily at exactly the same time the last update happened => inconsistencies
  //any movement on characters - especially when adding character cameras for following things around: 
  //make it happen after all the physics has been calculated => LateUpdate() > Update()
  
  void LateUpdate(){
      
    //add the goal vector of unit length 1 onto the transform vector of the character - move at the same rate for different goal
    //smooth out and allow for the difference in the update running
    
    //snap the character around to look at the goal and turn to that direction before translation
    this.transform.LookAt(goal.position);
      
    //calculate the differences between the goal position and the current position
    Vector3 direction = goal.position - this.transform.position; 
 
    Debug.DrawRay(this.transform.position, direction, Color.red);
    
    //if the goal is reached: stop calculation. translate the character in world space to prevent weird rotation behaviour
    if(direction.magnitude > accurateDistToGoal){
      this.transform.Translate(goal.normalized * speed * Time.deltaTime, Space.World);
    }
  }
}
