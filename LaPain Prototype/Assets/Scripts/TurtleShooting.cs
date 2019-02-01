using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleShooting : MonoBehaviour {

    float timer;
    
    Light laserLight;
    public GameObject laserBeam;
    public Transform gunBarrelEnd;

    public float timeBetweenShots;

    bool friendlyFire = false;

	// Use this for initialization
	void Awake () {
        
        laserLight = GetComponent<Light>();
        
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        

        if (timer >= timeBetweenShots && Time.timeScale != 0 && !friendlyFire) {
            Shoot();
        }       

    }

    void Shoot()
    {
        timer = 0;

        //Turn on Gun Light
        laserLight.enabled = true;

       // Spawn Noob Tube shells           
        Instantiate(laserBeam, gunBarrelEnd.position, gunBarrelEnd.rotation);

    }
}
