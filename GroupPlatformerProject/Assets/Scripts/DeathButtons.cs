using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathButtons : MonoBehaviour {

    public void Continue()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Application.Quit");
    }
}
