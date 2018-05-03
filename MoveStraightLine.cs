using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//moving objects without physics

public class MoveStraightLine : MonoBehaviour{
  
  //humanoid character - no floating in y direction
  Vector3 goal = new Vector3(5,0,4); 

  void Start(){
  //add the goal vector onto the transform vector of the character
    this.transform.Translate(goal);
  }
}
