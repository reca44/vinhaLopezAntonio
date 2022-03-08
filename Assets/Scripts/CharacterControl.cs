using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Animator animator;
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
            animator.SetBool("run", true);

        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            spriteRenderer.flipX = true;
            rb.velocity = new Vector2(-velocidadCorrer, rb.velocity.y);
            animator.SetBool("run", true);

        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            animator.SetBool("run", false);
        }
        if (Input.GetKey("space") && contacto.isGrounded)
        {
            rb.AddForce(new Vector2(0, 10));

        }
        //intente hacer un doble salto pero no me funciona
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
    }

}
