using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovement : MonoBehaviour {

    public float turtleSpeed;
    
    int direction = 1; //Start Moving the Turtle Up
    int topBorder = 4;
    int botBorder = -4;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        if (transform.position.y >= topBorder) {
            direction = -1;
        }

        else if (transform.position.y <= botBorder) {
            direction = 1;
        }

        transform.Translate(0, turtleSpeed * direction * Time.deltaTime, 0);
	}
}
