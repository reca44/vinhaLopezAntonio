using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float velocidadCorrer = 6f;
    public float velocidadSalto = 18f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            spriteRenderer.flipX = false;
            rb.velocity = new Vector2(velocidadCorrer, rb.velocity.y);
            
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            spriteRenderer.flipX = true;
            rb.velocity = new Vector2(-velocidadCorrer, rb.velocity.y);
            
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetKey("space") && contacto.isGrounded)
        {
            // rb.velocity = new Vector2(rb.velocity.x, velocidadSalto);
            rb.AddForce(new Vector2(0, 10));

        }
        //if (Input.GetKey("space"))
        //{
        //    if (contacto.isGrounded)
        //    {
        //        dobleSalto = true;
        //        rb.velocity = new Vector2(rb.velocity.x, velocidadSalto);
        //        rb.AddForce(new Vector2(0, 10));
        //    }
        //    else
        //    {
        //        if (Input.GetKey("space"))
        //        {
        //            if (dobleSalto)
        //            {

        //                rb.velocity = new Vector2(rb.velocity.x, doblejumpVel);
        //                dobleSalto = false;
        //            }
        //        }
        //    }
        //}






        //if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") > 0)
        //{
        //    spriteRenderer.flipX = false;
        //}
        //else if (Input.GetButtonDown("Horizontal") && Input.GetAxisRaw("Horizontal") < 0)
        //{
        //    spriteRenderer.flipX = true;
        //}






        //if (Input.GetButtonDown("Jump"))
        //{
        //    if (contacto.isGrounded)
        //    {
        //        dobleSalto = true;
        //        rb.AddForce(new Vector2(0, 250));
        //    }
        //    else
        //    {
        //        if (Input.GetButtonDown("Jump"))
        //        {
        //            if (dobleSalto)
        //            {
        //                rb.AddForce(new Vector2(0, 250));
        //                dobleSalto = false;
        //            }
        //        }
        //    }
        //}


        //Vector2 velocidad = /*/*new Vector2(dirX * 5, rb.velocity.y);*/*/



        //if(dirX>0){
        //  animator.Play("run",-1,0f);
        //}else if(dirX<0){
        //  animator.Play("idle",-1,0f);
        //}

        //rb.velocity = velocidad;
    }

}
