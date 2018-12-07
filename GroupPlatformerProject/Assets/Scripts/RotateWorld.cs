using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWorld : MonoBehaviour {

    public float rotateSpeed = 3.0f;
    public GameObject RotateCamera;
    //public GameObject mainCamera;
    public float smooth = 1f;
    private Quaternion targetRotation;
    public bool rotateMe = false;
    float degrees = 0;
    Vector3 speed;
    // Use this for initialization
    void Start () {
        
        targetRotation = RotateCamera.transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {
        if (rotateMe && degrees < 180)
        {
            RotateCamera.transform.Rotate(0, 0, rotateSpeed, Space.World);
            degrees += rotateSpeed;
            GetComponent<PlayerMove>().enabled = false;
            speed = GetComponent<Rigidbody2D>().velocity;
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
        else
        {
            rotateMe = false;
            degrees = 0;
            GetComponent<PlayerMove>().enabled = true;
            GetComponent<Rigidbody2D>().velocity = speed;
        }
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RotateTrigger")
        {
            //Time.timeScale = 0;
            rotateMe = true;
            //targetRotation *= Quaternion.AngleAxis(180, new Vector3(0,0,1));
            //RotateCamera.transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
            //RotateCamera.transform.Rotate(0, 0, rotateSpeed, Space.World);
        }
    }
}
