using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float speed;
    public float input;
    public SpriteRenderer spriteRenderer;
    public float jumpForce;
    public ScoreScript sc;
    public float fallingGravityScale = 40;
    public float jumpAmount = 15;
    public float gravityScale = 50;
    public AudioSource damageNoise;
    

    // Update is called once per frame
    void Update()
    {
        // this function swaps the direction loaf is facing depending on whether he is going right or left
        input = Input.GetAxisRaw("Horizontal");
        if(input < 0){
            spriteRenderer.flipX = true;
        }
        else if (input > 0){
            spriteRenderer.flipX = false;
        }
            {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }

        if(playerRb.velocity.y >= 0)
        {
            playerRb.gravityScale = gravityScale;
        }
        else if (playerRb.velocity.y < 0)
        {
            playerRb.gravityScale = fallingGravityScale;
        }
    }
        // this function calls from the GameOver file and brings up the Game Over screen if Loaf's life count is 0 or below
        if (sc.lifeCount<=0){
            LoadGameOver();
        }
    }

    void FixedUpdate()
    {
        playerRb.velocity = new Vector2 (input * speed, playerRb.velocity.y);
    }
    // this function adds 1 to the Spread Count everytime Loaf collides with a spread
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Spread")){
            Destroy(other.gameObject);
            sc.spreadCount++;
        }
    }

    // this function is called when Loaf collides with particular Tags
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Enemy")){
            damageNoise.Play();
            sc.lifeCount--;
        }
        // this statatement navigates to level 2 when Loaf reaches the bread bin
        if(collision.gameObject.CompareTag("BreadBin")){
            LoadLevelTwo();
        }
        // this statatement navigates to the final level when Loaf reaches the bread bin
        if(collision.gameObject.CompareTag("BreadBinL2")){
            LoadFinalLevel();
        }
        // this statatement shows the Game Complete screen when Loaf reaches the bread bin
        if(collision.gameObject.CompareTag("BreadBinFinal")){
            LoadGameCompleteScreen();
        }
    }

    public void LoadLevelTwo(){   
        
        SceneManager.LoadScene("LevelTwo");
        
    }
    public void LoadFinalLevel(){   
        
        SceneManager.LoadScene("FinalLevel");
        
    }
    public void LoadGameCompleteScreen(){   
        
        SceneManager.LoadScene("GameCompleteScreen");
        
    }

    public void LoadGameOver(){   
        
        SceneManager.LoadScene("GameOver");
        
    }
}