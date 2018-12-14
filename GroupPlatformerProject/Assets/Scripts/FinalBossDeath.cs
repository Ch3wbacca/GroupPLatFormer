using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBossDeath : MonoBehaviour {

    public GameObject Boss;
    public int BossHP = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Throwing thingy" && BossHP <= 0)
        {
            Boss.SetActive(false);
        }
        if (collision.gameObject.tag == "Throwing thingy")
        {
            BossHP--;
        }
    }
}
