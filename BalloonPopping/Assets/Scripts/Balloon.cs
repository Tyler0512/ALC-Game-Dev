using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Balloon : MonoBehaviour
{

    public int clickToPop = 3; //How many clicks to pop the balloon
    public float scaleToIncrease = 0.10f; //Scale increase per click
    public int scoreToGive; // Score to give when popped
    private ScoreManager scoreManager; // A variable to reference the score manager
    public GameObject popEffect; // Refernce Pop Effect Particle System

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Reference ScoreManager Component*
        //scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        // Reduce the clickToPop by 1
        clickToPop -= 1;
        //increase the size of the balloon
        transform.localScale += Vector3.one * scaleToIncrease;

        if (clickToPop == 0)
        {
            // Increase the score
            //scoreManager.IncreaseScoreText(scoreToGive);
            // Instantiate the pop effect
            //Instantiate(popEffect, transform.position, transform.rotation);
            // Destroy the balloon
            Destroy(gameObject);
        }
    }
}
