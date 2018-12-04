using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasePlayer : MonoBehaviour
{
    public GameObject player;
    public float chaseSpeed = 3.0f;
    public float chaseTriggerDistance = 3.0f;
    public Vector3 paceDirection = new Vector3(0, 0, 0);
    public float paceDistance = 3.0f;
    public float paceSpeed = 2.0f;
    Vector3 startPosition;
    bool home = true;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 chaseDirection = playerPosition - transform.position;
        if (chaseDirection.magnitude < chaseTriggerDistance)
        {
            //chase the player
            home = false;
            chaseDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;

        }
        else if (home == false)
        {
            Vector3 homeDirection = startPosition - transform.position;
            if (homeDirection.magnitude < 0.5f)
            {
                home = true;
                transform.position = startPosition;
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            }
            else
            {
                //go home
                homeDirection.Normalize();
                GetComponent<Rigidbody2D>().velocity = homeDirection * paceSpeed;
            }
        }
        else
        {
            //pace back and forth
            Vector3 displacement = transform.position - startPosition;
            float distanceFromStart = displacement.magnitude;
            if (distanceFromStart >= paceDistance)
            {
                //turn around, we've gone too far
                paceDirection = paceDirection;

            }
            paceDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity =
                paceDirection * paceSpeed;
        }

        float Left = Input.GetAxis("Horizontal");
        float Right = Input.GetAxis("Horizontal");
        


        if (Mathf.Abs(X) > 0)
        {
            
            GetComponent<Animator>().SetFloat("Right", Right);

        }

    }
}
