using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {
    public int health = 10;
    private Object drop;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Arrow")
            health--;
        if (health <= 0)
        {
            Destroy(gameObject);
            if (health == 0)
            {
                
                Destroy(gameObject);
               
            }
        }
    }
}
