using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float jumpPower;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        //Vector3 velocity = rb2d.velocity;
        //velocity.y = jumpPower;
        //rb2d.velocity = velocity;
        rb2d.AddForce(new Vector2(0, jumpPower));
    }
}
