using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svich_cam : MonoBehaviour
{
    public GameObject cam;
    
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.tag == "Player"){
            cam.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D coll){
        if (coll.tag == "Player"){
            cam.SetActive(false);
        }
    }
}
