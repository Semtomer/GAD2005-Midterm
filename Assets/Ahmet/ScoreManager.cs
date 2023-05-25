
using UnityEngine;
using System.Text.RegularExpressions;

public class ScoreManager : MonoBehaviour
{
    private int currentScore;
    private int highScore;

    private const string HighScoreKey = "HighScore";

    void Start()
    {
        // Get the high score from PlayerPrefs
        highScore = PlayerPrefs.GetInt(HighScoreKey);

        // Get the current score from PlayerPrefs
        currentScore = PlayerPrefs.GetInt("CurrentScore");
        ResetScore();
    }

    // Increase the score
    public void IncreaseScore(int amount)
    {
        highScore = PlayerPrefs.GetInt(HighScoreKey);
        // Save the last score to PlayerPrefs
        PlayerPrefs.SetInt("LastScore", amount);
        PlayerPrefs.Save();

        // Get the current score from PlayerPrefs
        currentScore = PlayerPrefs.GetInt("CurrentScore", 0);

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
        Debug.Log("score: " + currentScore);
    }

    // Decrease the score
    public void DecreaseScore(int amount)
    {
        currentScore -= amount;

        // Ensure the score doesn't go below zero
        if (currentScore < 0)
        {
            currentScore = 0;
        }

        // Save the current score to PlayerPrefs
        PlayerPrefs.SetInt("CurrentScore", currentScore);
        PlayerPrefs.Save();
    }

    public int MultiplyNumbersInName(string objectName)
    {
        // Use regular expressions to match and extract numbers from the name
        MatchCollection matches = Regex.Matches(objectName, @"\d+");

        int result = 1;

        // Multiply the extracted numbers together
        foreach (Match match in matches)
        {
            int number;

            if (int.TryParse(match.Value, out number))
            {
                result *= number;
            }
        }

        Debug.Log("Multiplication Result: " + result);

        return result;
    }

    // Reset the score
    public void ResetScore()
    {
        currentScore = 0;

        // Reset the current score in PlayerPrefs
        PlayerPrefs.SetInt("CurrentScore", currentScore);
        PlayerPrefs.Save();
    }

    // Get the high score
    public int GetHighScore()
    {
        return highScore;
    }
}
