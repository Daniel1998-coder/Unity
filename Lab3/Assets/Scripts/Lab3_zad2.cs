using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_zad2 : MonoBehaviour{
    public float speed;
    int direction = 1;

    void FixedUpdate(){
        if(GetComponent<Transform>().position.x >= 5)
        {
            direction = -1;
        }
        else if(GetComponent<Transform>().position.x <= -5)
        {
            direction = 1;
        }
        transform.Translate(direction*speed* Time.deltaTime, 0, 0);
    }
}
