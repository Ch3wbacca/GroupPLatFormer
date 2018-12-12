using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject prefab;
    public float shootSpeed = 10;
    float timer = 0;
    public float fireRate = 0.3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer > fireRate) 
        {
           
            timer = 0;
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log(mousePosition);
            //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            Plane xy = new Plane(Vector3.forward, new Vector3(0, 0, 0));
            float distance;
            xy.Raycast(ray, out distance);
            mousePosition = ray.GetPoint(distance);
            //mousePosition = Camera.main.ViewportToWorldPoint(mousePosition);
            mousePosition.z = 0;
            Debug.Log(mousePosition);
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            //destination - start position
            GameObject bullet = (GameObject)Instantiate(prefab,
                transform.position, Quaternion.identity);
            //bullet.transform.forward = mousePosition;
            Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            diff.Normalize();
            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0f, 0f, rot_z);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * shootSpeed;
            Destroy(bullet, 0.70f);

        }
	}
}
