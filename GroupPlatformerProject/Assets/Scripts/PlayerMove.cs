using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    bool grounded = false;
    public float jumpSpeed = 1.0f;
    public float moveSpeed = 1.0f;
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        
         
        
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;
        if (Input.GetButtonDown("Jump") && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(
                new Vector2(0, 100 * jumpSpeed));
            GetComponent<Animator>().SetBool("jumping", true);
            GetComponent<Animator>().SetFloat("x", 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
            GetComponent<Animator>().SetBool("jumping", false);
            GetComponent<Animator>().SetFloat("x", 1);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = false;
        }
    }

}
