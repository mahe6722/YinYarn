using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLaser : MonoBehaviour {

    public float laserSpeed;
    int direction = -1;

    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(laserSpeed * direction * Time.deltaTime, 0, 0);
    }
}
