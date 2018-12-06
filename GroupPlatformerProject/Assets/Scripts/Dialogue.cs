using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour {

    // Use this for initialization
    
    public GameObject entry;
    public GameObject p;
    public GameObject pp;
    public GameObject pa;
    public GameObject pppppa;
    public GameObject a;
    public GameObject ap;
    public GameObject aa;
    public GameObject s1;
    public GameObject s2;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "King")
        {
            entry.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void P()
    {
        entry.SetActive(false);
        p.SetActive(true);
    }
    public void PP()
    {
        p.SetActive(false);
        pp.SetActive(true);
    }
    public void A()
    {
        entry.SetActive(false);
        a.SetActive(true);
    }
    public void S1()
    {
        entry.SetActive(false);
        p.SetActive(false);
        pp.SetActive(false);
        a.SetActive(false);
        s1.SetActive(true);
    }
    public void PPPPPA()
    {
        pp.SetActive(false);
        pppppa.SetActive(true);
    }
    public void PA()
    {
        p.SetActive(false);
        pa.SetActive(true);
    }
    public void AP()
    {
        a.SetActive(false);
        ap.SetActive(true);
    }
    public void AA()
    {
        a.SetActive(false);
        aa.SetActive(true);
    }
    public void S2()
    {
        s1.SetActive(false);
        s2.SetActive(true);
    }
    public void PAD()
    {
        pa.SetActive(false);
        Time.timeScale = 1;
    }
    public void PPPPPAD()
    {
        pppppa.SetActive(false);
        Time.timeScale = 1;
    }
    public void APD()
    {
        ap.SetActive(false);
        Time.timeScale = 1;
    }
    public void AAD()
    {
        aa.SetActive(false);
        Time.timeScale = 1;
    }
    public void S3()
    {
        s2.SetActive(false);
        Time.timeScale = 1;
    }
}
