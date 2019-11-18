﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float jumpForce = 10f;
    public static bool colliderCheck = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = new Vector2(0f, jumpForce);
                /*Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;*/

                colliderCheck = true;
            }
        /*
            if (collision.gameObject.tag == "Player")
            {
                Destroy(gameObject);
            }
        */
        }
    }

}