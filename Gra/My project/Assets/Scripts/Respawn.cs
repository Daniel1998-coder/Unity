 using UnityEngine;
 using System.Collections;
 
 public class Respawn : MonoBehaviour {
     public float Fall;
 
     void FixedUpdate () {
         if (transform.position.y < Fall)
             transform.position = new Vector3(0, 0, 0);
     }
 }