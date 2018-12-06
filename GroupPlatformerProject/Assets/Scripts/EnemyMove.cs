using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    Vector3 startPosition;
    public Vector3 paceDirection = new Vector3(0, 0, 0);
    public float paceDistance = 3.0f;
    public float moveSpeed = 3.0f;
    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
        paceDirection.Normalize();
        paceDirection = paceDirection * moveSpeed;

        float moveX = Input.GetAxis("Horizontal");
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;
        int x = (int)Input.GetAxisRaw("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacement = transform.position - startPosition;
        float distance = displacement.magnitude;
        if (distance >= paceDistance)
        {
            paceDirection = startPosition - transform.position;
        }
        paceDirection.Normalize();

        GetComponent<Rigidbody2D>().velocity = paceDirection * moveSpeed;
        int x = (int)Mathf.RoundToInt(paceDirection.normalized.x);
        GetComponent<Animator>().SetInteger("x", x);
    }
}

