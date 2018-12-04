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
        float X = Input.GetAxis("Horizontal");
        bool idle = true;
        bool jumping = false;
        float Y = Input.GetAxis("Vertical");
        if (Mathf.Abs(X) > 0)
        {
            GetComponent<Animator>().SetFloat("X", X);
            GetComponent<Animator>().SetFloat("Y", Y);

        }
        if (Mathf.Abs(Y) > 0)
        {
            GetComponent<Animator>().SetFloat("X", X);
            GetComponent<Animator>().SetFloat("Y", Y);
            jumping = true;
        }
        if (X == 0)
        {
            GetComponent<Animator>().SetBool("Idle", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Idle", false);
        }
        if (Y == 0)
        {
            jumping = false;
        }


    }
}
