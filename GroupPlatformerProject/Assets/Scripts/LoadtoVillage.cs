using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadtoVillage : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Debug.Log(gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            //load entrance
            SceneManager.LoadScene("Village");


        }



    }
}
