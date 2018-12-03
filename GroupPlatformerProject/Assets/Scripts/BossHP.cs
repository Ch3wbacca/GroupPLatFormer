using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour {
    public int health = 10;
    private Object drop;
    public GameObject Door;
    public GameObject Door2;
    public GameObject Trigger;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Arrow")
            health--;
        if (health <= 0)

        {
            Destroy(gameObject);
            if (health == 0)
            {
                Door2.SetActive(false);
                Trigger.SetActive(false);
                Destroy(gameObject);
                Door.SetActive(false);
            }
        }





        }
    }

