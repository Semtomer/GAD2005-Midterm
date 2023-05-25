using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreUpdater : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        // Retrieve the score from PlayerPrefs and update the text
        int score = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "Score: " + score;
    }

    private void UpdateScoreText()
    {
        // Retrieve the score from PlayerPrefs and update the text
        int score = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + score;
    }
}

