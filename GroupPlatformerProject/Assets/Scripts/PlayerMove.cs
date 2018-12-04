using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    bool Jumping = false;
    bool grounded = true;
    public float jumpSpeed = 1.0f;
    public float moveSpeed = 1.0f;
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float X = Input.GetAxis("Horizontal");
        GetComponent<Animator>().SetFloat("X", X);
        if (X == 0)
        {
            GetComponent<Animator>().SetBool("Idle", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Idle", false);
        }

        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;
        if (Input.GetButtonDown("Jump") && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(
                new Vector2(0, 100 * jumpSpeed));
            GetComponent<Animator>().SetBool("Jumping", true);
            GetComponent<Animator>().SetFloat("X", 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
            GetComponent<Animator>().SetBool("Jumping", false);
            GetComponent<Animator>().SetFloat("X", 1);
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
