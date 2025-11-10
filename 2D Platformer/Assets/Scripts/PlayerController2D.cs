using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerController2D : MonoBehaviour
{

    //Value Types
    [Header("Player Settings")]
    public float moveSpeed; // How fast the player moves side to side
    public float jumpForce; // How high the player jumps
    public bool isGrounded; // Is the player grounded or not
    public int bottomBound = -4; // Store bottom boundary value
    [Header("Score")]
    public int score; // Store the score value


    //Reference Types
    public Rigidbody2D rig; // Rigidbody Reference
    public TextMeshProUGUI scoreText; // Text UI Reference


    public void AddScore(int amount)
    {
        //Add to score
        score += amount;
        //Update score text UI
        scoreText.text = "Score: " + score;
    }



    void FixedUpdate()
    {
        // Gather Inputs
        float moveInput = Input.GetAxisRaw("Horizontal");
        //Make the player move side to side
        rig.linearVelocity = new Vector2(moveInput * moveSpeed, rig.linearVelocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        // If we press the jump button and we are grounded, then jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false; // We are no longer grounded
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // Jump
        }

        if (transform.position.y < bottomBound)
        {
            GameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // If we collide with the ground, we are grounded
        if (collision.GetContact(0).normal == Vector2.up)
        {
            isGrounded = true;
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}

