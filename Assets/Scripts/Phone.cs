using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public GameObject phone;
    private bool PhoneIsOn = false;

    private Transform Menu;
    void Start()
    {
        Menu = Object.FindObjectOfType("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (PhoneIsOn == false)
        {   if (Input.GetAxis("Fire2") == 1)
            {
                phone.SetActive(true);
                PhoneIsOn = true;
            }
  
        }
        else if (PhoneIsOn == true)
        {
            if (Input.GetAxis("Fire2") == -1)
            {
                phone.SetActive(false);
                PhoneIsOn = false;
            }

        }

    }


    public void Calls ()
    {
        Debug.Log("Calls");
    }

    public void SMS()
    {
        Debug.Log("SMS!");
    }

    public void My_univer()
    {
        Debug.Log("Unik!");
    }
}
