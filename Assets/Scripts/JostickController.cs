using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JostickController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    [SerializeField] VariableJoystick joystick;


    Vector2 moveDirection;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MyInput();

    }

    void FixedUpdate()
    {
        Movement();
    }

    private void MyInput()
    {
        float x = joystick.Horizontal;
        float y = joystick.Vertical;

        moveDirection = new Vector2(x, y);
    }

    void Movement()
    {
        rb.velocity = moveDirection * speed * Time.deltaTime;
        if (rb.velocity != Vector2.zero)
        {
            transform.up = rb.velocity;
        }
    }
}
