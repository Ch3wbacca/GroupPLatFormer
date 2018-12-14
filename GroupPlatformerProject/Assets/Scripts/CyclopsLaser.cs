using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclopsLaser : MonoBehaviour {

    public float laserTimer = 0;
    public GameObject Laser;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        laserTimer += Time.deltaTime;
        if(laserTimer == 3)
        {
            laserTimer = 0;
            Laser.SetActive(true);
        }
        if (laserTimer == 1)
        {
            Laser.SetActive(false);
        }
	}
}
