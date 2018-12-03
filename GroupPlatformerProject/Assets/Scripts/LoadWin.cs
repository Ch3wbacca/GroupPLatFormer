using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadWin : MonoBehaviour {



     private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //assuming we're attaching this script to the object
            //at the end of the level
            SceneManager.LoadScene("WinScene");

   
        }

       

    }
}
    