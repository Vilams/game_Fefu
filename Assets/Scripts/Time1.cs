using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time1 : MonoBehaviour
{
    public float GameSecond_temp;
    public int GameSecond;
    public int GameMinutes;
    private string stringSecond;
    private string stringMinutes;
    int count = 1;

    public Text TimeHUD;
    
    void Update()
    {
        GameSecond_temp += Time.deltaTime;

        if (GameSecond_temp >= count ){
            GameSecond++;
            count++;
        }
        if (GameSecond >= 60){
            GameSecond = 0;
            GameMinutes++;
            count=1;
        }
        if (GameMinutes == 24 && GameSecond >=60){
            GameSecond=0;
            GameMinutes=0;
            count=1;
        }
        
       stringSecond = GameSecond.ToString();
       stringMinutes = GameMinutes.ToString();
       TimeHUD.text =  stringMinutes + ":" + stringSecond;
    }
}
