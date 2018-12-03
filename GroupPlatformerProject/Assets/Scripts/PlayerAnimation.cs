using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);
        float y = Input.GetAxis("Vertical");
        if (Mathf.Abs(x) > 0)
        {
            GetComponent<Animator>().SetFloat("x", x);

        }
        if (x == 0)
        {
            GetComponent<Animator>().SetBool("Idle", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Idle", false);
        }

    }
}
