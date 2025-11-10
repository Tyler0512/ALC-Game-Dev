using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Coin : MonoBehaviour
{
    [Header("Coin Attributes")]

    public int scoreToGive;
    private float startYPos;
    public float bobHeight;
    public float bobSpeed;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            // Add to the player's score
            collision.GetComponent<PlayerController2D>().AddScore(scoreToGive);
            // Destroy the coin
            Destroy(gameObject);
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startYPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startYPos + (Mathf.Sin(Time.time * bobSpeed) * bobHeight);
        transform.position = new Vector3(transform.position.x, newY, 0);
    }
}
