using UnityEngine;
using System.Collections;
using System.Collections.Generic;  

public class MoveUp : MonoBehaviour
{

    public float speed;
    public float upperBound = 36.0f;
    public ScoreManager scoreManager; // Referencing the score manager script and storing it in a variable scoreManager
    public Balloon balloon; // Referencing the balloon script and storing it in a variable balloon

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();

    }

    // Update is called once per frame
    void Update()
    {
        // Move the object upward at a constant speed
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y >= upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive); // Decrease the score by the scoreToGive amount
            Destroy(gameObject); // Destroy the balloon
        }
    }
}
