using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement; //get horizontal and vertical
    // Update is called once per frame
    public Joystick joystick;
    void Update()//Input
    {
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;
    }
    void FixedUpdate()//movement
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
