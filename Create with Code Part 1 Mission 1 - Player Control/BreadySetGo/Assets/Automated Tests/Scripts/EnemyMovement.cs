using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float jumpForce = 5f; // The force applied when jumping
    public float jumpInterval = 2f; // Time between jumps
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(Jump), 0, jumpInterval); // Call Jump method at specified intervals
    }

    void Update()
    {
        // Check if the sprite is grounded
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
    }

    void Jump()
    {
        if (isGrounded) // Only jump if the sprite is grounded
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}

