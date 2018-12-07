using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateWorld : MonoBehaviour {

    public float rotateSpeed = 3.0f;
    public GameObject RotateCamera;
    //public GameObject mainCamera;
    public float smooth = 1f;
    private Quaternion targetRotation;
    public bool rotateMe = false;
    float degrees = 0;
    public GameObject wall1;
    public GameObject wall2;
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
        else if (rotateMe && degrees >= 180)
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
            wall1.SetActive(true);
            wall2.SetActive(true);
            //targetRotation *= Quaternion.AngleAxis(180, new Vector3(0,0,1));
            //RotateCamera.transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
            //RotateCamera.transform.Rotate(0, 0, rotateSpeed, Space.World);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Wall1")
        {
            SceneManager.LoadScene("UpsideDown1");
        }
        if (collision.gameObject.name == "Wall2")
        {
            SceneManager.LoadScene("UpsideDown1");
        }
    }
}
