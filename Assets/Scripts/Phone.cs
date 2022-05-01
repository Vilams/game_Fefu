using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public GameObject phone;
    private bool PhoneIsOn = false;

    private GameObject Menu;
    private GameObject Message;
    private GameObject Univer;
    private GameObject Call;
    void Start()
    {
        phone.SetActive(true);
        Menu = GameObject.Find("Phone/Phone_Body/Menu");
        Message = GameObject.Find("Phone/Phone_Body/SMS");
        Univer = GameObject.Find("Phone/Phone_Body/My_University");
        Call = GameObject.Find("Phone/Phone_Body/Calls");
        phone.SetActive(false);
    }

    
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
        Call.SetActive(true);
        Menu.SetActive(false);
    }

    public void SMS()
    {
        Message.SetActive(true);
        Menu.SetActive(false);
    }

    public void My_univer()
    {
        Univer.SetActive(true);
        Menu.SetActive(false);
    }

    public void Home()
    {
        Menu.SetActive(true);
        Univer.SetActive(false);
        Message.SetActive(false);
        Call.SetActive(false);
    }
}
