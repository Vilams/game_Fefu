using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigerfloorswich : MonoBehaviour
{   public GameObject tpPosition;
    private Vector3 position;

   
    void OnTriggerStay2D(Collider2D coll){
        if(coll.tag == "Player"){
           coll.gameObject.transform.position = tpPosition.gameObject.transform.position;
        }
    }

    
}
