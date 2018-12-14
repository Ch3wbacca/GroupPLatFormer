using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneLoad : MonoBehaviour {

    public GameObject BG1;
    public GameObject BG2;
    public GameObject BG3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(!BG1.activeSelf && !BG2.activeSelf && !BG3.activeSelf)
        {
            SceneManager.LoadScene("WinScene");
            Debug.Log("Loading WinScene");
        }
	}
}
