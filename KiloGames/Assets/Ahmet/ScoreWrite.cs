
using UnityEngine;
using TMPro;

public class ScoreWrite : MonoBehaviour
{
    private int currentScore;
    private int highScore;

    private const string HighScoreKey = "HighScore";
    public TextMeshProUGUI scoreText;

    void Start()
    {
        // Get the high score from PlayerPrefs
        highScore = PlayerPrefs.GetInt(HighScoreKey, 0);

        // Get the current score from PlayerPrefs
        currentScore = PlayerPrefs.GetInt("CurrentScore", 0);

        UpdateScoreText();
    }

    // Increase the score
    public void IncreaseScore(int amount)
    {
        currentScore += amount;

        // Check and update the high score
        if (currentScore > highScore)
        {
            highScore = currentScore;

            // Save the new high score to PlayerPrefs
            PlayerPrefs.SetInt(HighScoreKey, highScore);
            PlayerPrefs.Save();
        }

        // Save the current score to PlayerPrefs
        PlayerPrefs.SetInt("CurrentScore", currentScore);
        PlayerPrefs.Save();

        UpdateScoreText();
    }

    // Reset the score
    public void ResetScore()
    {
        currentScore = 0;

        // Reset the current score in PlayerPrefs
        PlayerPrefs.SetInt("CurrentScore", currentScore);
        PlayerPrefs.Save();

        UpdateScoreText();
    }

    // Get the high score
    public int GetHighScore()
    {
        return highScore;
    }

    // Update the score text
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore;
        }
    }
}

