using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float speed;
    public float input;
    public SpriteRenderer spriteRenderer;
    public float jumpForce;
    public ScoreScript sc;

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        if(input < 0){
            spriteRenderer.flipX = true;
        }
        else if (input > 0){
            spriteRenderer.flipX = false;
        }

        if (Input.GetButton("Jump")){
            playerRb.velocity = Vector2.up * jumpForce;
        }
    }

    void FixedUpdate()
    {
        playerRb.velocity = new Vector2 (input * speed, playerRb.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Spread")){
            Destroy(other.gameObject);
            sc.spreadCount++;
        }
    }
}
