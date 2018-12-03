using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour {
   
 public int health = 10;
    //public Text HealthText;
    public Slider healthBar;
    private bool OnCollision;
    private object onCollision;

    
    private void Start()
    {
        //HealthText.GetComponent<Text>().text = "Health: " + health;
        healthBar.GetComponent<Slider>().value = health;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            //HealthText.GetComponent<Text>().text = "Health: " + health;
            healthBar.GetComponent<Slider>().value = health;

        }
        if (collision.gameObject.tag == "HealthKit")

        {
            Destroy(collision.gameObject);
            health++;

            healthBar.GetComponent<Slider>().value = health;
        }



        if (health <= 0)
        {
            
            SceneManager.LoadScene("Death Scene");
        }
        if (collision.gameObject.tag == "Lava")
        {
            health--;
            healthBar.GetComponent<Slider>().value = health;
        }
    }
   




}
    