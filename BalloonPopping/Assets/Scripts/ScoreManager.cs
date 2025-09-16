using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro; // Add the UI namespace


public class ScoreManager : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI scoreText;  // Reference to the UI text component

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; // Increase the score by the specified amount
        UpdateScoreText();
    }

    public void DecreaseScoreText(int amount)
    {
        score -= amount; // Decrease the score by the specified amount
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
