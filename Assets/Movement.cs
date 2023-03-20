using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;

    public float upForce = 100;
    public float speed = 1500;
    public float runSpeed = 2500;

    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        if (move == 0)
        {
            anim.SetBool("IsWalk", false);
        }
        else
        {
            if (move > 0) 
            {
                transform.localScale = new Vector3(5, 5, 1);
            }
            else if (move<0)
            {
                transform.localScale = new Vector3(-5, 5, 1);
            }   

            if (Input.GetKey(KeyCode.LeftShift))



            {
                anim.SetBool("IsWalk", true);
                rb.velocity = new Vector2(move * runSpeed * Time.deltaTime, rb.velocity.y);
            }
            else
            {
                anim.SetBool("IsWalk", true);
                rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);
            }

        }
        

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * upForce);
            isGrounded = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}
