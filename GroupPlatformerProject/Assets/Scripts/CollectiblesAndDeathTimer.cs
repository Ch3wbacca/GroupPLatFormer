using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class CollectiblesAndDeathTimer : MonoBehaviour {

    public float timer = 15;
    public Slider timeLeft;

	// Use this for initialization
	void Start () {
        timeLeft.GetComponent<Slider>().value = timer;
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        timeLeft.GetComponent<Slider>().value = timer;
        if (timer <= 0)
        {
            SceneManager.LoadScene("Death Scene");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Collectable")
        {
            timer += 3;
            Destroy(collision.gameObject);
            timeLeft.GetComponent<Slider>().value = timer;
        }
    }
}
