using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce;

    private void OnCollisionEnter2D(Collision2D collision) {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

        Vector2 vel = rb.velocity;
        vel.y = jumpForce;
        rb.velocity = vel;
    }

   
}