using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private bool isJump;
    [SerializeField] private bool engelTouch;
    private Rigidbody2D rb;
    private int twojump;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        twojump = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            PlayerJump();
        }
    }
    private void FixedUpdate()
    {
        playerMove();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SagEngel"))
        {
            engelTouch = false;
            isJump = false;
        }
        if(collision.gameObject.CompareTag("SolEngel"))
        {
            engelTouch = true;
            isJump = false;
        }
        if (collision.gameObject.CompareTag("Platform"))
        {
            isJump = false;
            twojump = 2; //iki zýplamayý resetledik
        }
    }

    private void playerMove()
    {
        if(engelTouch)
        {
            transform.position += Vector3.right * speed * Time.fixedDeltaTime;
        }
        else
        {
            transform.position -= Vector3.right * speed * Time.fixedDeltaTime;
        }
    }

    private void PlayerJump()
    {
        

        if (!isJump)
        {
            
            rb.velocity = new Vector2(rb.velocity.y, jumpSpeed);
            isJump = true;
            twojump--;
        }
        
       
        
           
    }
}
