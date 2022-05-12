using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFull : MonoBehaviour
{   
    [Header("Moving")]
    public float speed;
    public float moveInput_x;
    public float moveInput_y;
    public bool Fasig = true;
    public Rigidbody2D rb;
    
    [Header("Stat")]
    public int HP;
    public Text HP_HUD;
    bool Flag = true;
    //public GameObject HillBotle;

    [Header("TimeHud")]
    public float GameSecond_temp;
    public int GameSecond;
    public int GameMinutes;
    private string stringSecond;
    private string stringMinutes;
    int count = 1;
    public Text TimeHUD;

    private void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    
    // Update is called once per frame
    private void FixedUpdate()
    
    {
        TimeBar();
        HP_Bar();
        moveInput_x = Input.GetAxis("Horizontal");
        if (Fasig==false && moveInput_x > 0 ){
            Flip();
        }else if  (Fasig==true && moveInput_x < 0 ){
            Flip();
        }
        rb.velocity = new Vector2(moveInput_x * speed, rb.velocity.y );
        
        
        moveInput_y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, moveInput_y * speed );
    }

    
    
    void Flip(){   // переворот спарйта персонажа при передвежении в обратеную сторону 
        Fasig= !Fasig;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale=Scaler;
    }
    void OnTriggerEnter2D(Collider2D coll){
        if(coll.tag == "Hill"){
            HP+=10;
            Destroy(coll.gameObject);

        }
    }


    void TimeBar() // худ времени 
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
    
    void HP_Bar(){ // худ хп    
       
       if(GameSecond%2==0 && Flag){
           HP--;
           Flag = false;
       }else if (GameSecond%2!=0){
           Flag = true;
       }
       HP_HUD.text=HP.ToString();
    }

}
