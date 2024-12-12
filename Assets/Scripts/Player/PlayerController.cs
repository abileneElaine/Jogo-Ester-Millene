using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveX;
    public float speed;
    public int addJumps;
    public bool isGrounded;
    public float jumpForce;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        Move();
    

     if(isGrounded == true)
     {
         addJumps = 1;
         if(Input.GetButtonDown("Jump"))
         {
             Jump();
         }
         else
         {
             if(Input.GetButtonDown("Jump") && addJumps > 0)
             {
                 addJumps--;
                 Jump();
             }
         }
     }

     void Move()
     {
            rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

            if(moveX >  0)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);

            }
            if(moveX < 0)
            {
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
     }
     void Jump()
     {
         rb.velocity = new Vector2(rb.velocity.x, jumpForce);
     }

     void OnCollisionEnter2D(Collision2D collision)
     {
         if(collision.gameObject.tag == "Ground")
         {
             isGrounded = true;
         }
     }

     void OnCollisionExit2D(Collision2D collision)
     {
         if(collision.gameObject.tag == "Ground")
         {
             isGrounded = false;
         }
     }
   
}   }
