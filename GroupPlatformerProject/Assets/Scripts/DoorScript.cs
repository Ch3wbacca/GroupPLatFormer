using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public GameObject Door;
     void OnTriggerEnter2D(Collider2D collision)
    {
        Door.SetActive(true);
    }
}
