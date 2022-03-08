using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{ 
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        
    }

public int maxJumps = 2;

private int jumps;
private float jumpForce = 5f;

    void Update()
    {
        float dirX=Input.GetAxis("Horizontal");
        float dirY=Input.GetAxis("Vertical");

    if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") > 0) {
     spriteRenderer.flipX=false;
    } else if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") < 0) {
     spriteRenderer.flipX=true;
    }
        

         
        Rigidbody2D rb=GetComponent<Rigidbody2D>();
        //if(Input.GetButton("Jump")){
          //  GetComponent<Rigidbody2D>().velocity=new Vector2(dirX*5,6);
        //}else{
        //rb.velocity=new Vector2(dirX*6,rb.velocity.y); 
        //}


           
         Vector2 velocidad = new Vector2(dirX * 5, rb.velocity.y);
       
        if (Input.GetButtonDown("Jump")) {
            //rb.AddForce(new Vector2(0, 250));
            this.Jump ();
        }
        // Animation animator=new Animation();
        //if(dirX>0){
          //  animator.Play("run",-1,0f);
        //}else if(dirX<0){
          //  animator.Play("idle",-1,0f);
        //}

        rb.velocity = velocidad;
    }

    private void Jump()
{
  if(suelo.isGrounded==false){
    if (jumps > 0)
    {
        Rigidbody2D rb=GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, 250));
        jumps = jumps - 1;
        
    }
    if (jumps == 0)
    {
        return;
    }
      }
}


}
