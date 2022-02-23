using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
             float dirX=Input.GetAxis("Horizontal");
        float dirY=Input.GetAxis("Vertical");
        
        Rigidbody2D rb=GetComponent<Rigidbody2D>();
        //if(Input.GetButton("Jump")){
          //  GetComponent<Rigidbody2D>().velocity=new Vector2(dirX*5,6);
        //}else{
        //rb.velocity=new Vector2(dirX*6,rb.velocity.y); 
        //}

           
         Vector2 velocidad = new Vector2(dirX * 5, rb.velocity.y);
 
        if (Input.GetButtonDown("Jump")) {
            rb.AddForce(new Vector2(0, 500));
        }
 
        rb.velocity = velocidad;
    }
    
}
