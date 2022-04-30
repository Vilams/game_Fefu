using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_skript : MonoBehaviour
{
    public float speed;
    public float moveInput_x;
    public float moveInput_y;
    public bool Fasig = true;
    public Rigidbody2D rb;
    private void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    
    // Update is called once per frame
    private void FixedUpdate()
    {
       
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
    void Flip(){
        Fasig= !Fasig;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale=Scaler;
    }
}
