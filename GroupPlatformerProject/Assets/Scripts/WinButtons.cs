using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinButtons : MonoBehaviour
{


    public void NewGame()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void QuitGame()
    {
        Application.Quit();

    }


}
