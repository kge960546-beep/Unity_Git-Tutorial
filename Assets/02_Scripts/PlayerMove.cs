using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField] private float speed = 5;

    private float inputX;

    Rigidbody2D rb;
    SpriteRenderer sprd;
    Animator anim;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprd = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");

        if(inputX != 0)
        {
            if(inputX < 0)
            {
                sprd.flipX = true;
            }
            else
            {
                sprd.flipX= false;
            }            
        }
        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));
    }


    void FixedUpdate()
    {
        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
    }
}
