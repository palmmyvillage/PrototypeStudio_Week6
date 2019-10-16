using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cha_Controller : MonoBehaviour
{
    private Rigidbody2D rb;

    public float H_speed;
    public float jumpForce;

    private bool touchGround;
    private float V_H, V_V;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        V_H = Input.GetAxis("Horizontal") * H_speed;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }
        
        V_V = rb.velocity.y; 
        rb.velocity = new Vector2(V_H,V_V);
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        
    }
}
