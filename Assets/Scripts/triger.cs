using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triger : MonoBehaviour
{
    public int levolLoad;
    public Vector3 position;
    void OnTriggerStay2D(Collider2D coll){
        if(coll.tag == "Player"){
           
            if (Input.GetAxis("Fire1") == 1 ){
                SceneManager.LoadScene(levolLoad);
            }
        }
    }

    void OnTriggerExit2D(Collider2D coll){
        if(coll.tag == "Player"){
            Debug.Log("ПИЗДУЙ НАХУЙ");
        }
    }
}
