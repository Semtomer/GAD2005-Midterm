
using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    void Update()
    {
        // Retrieve the score from PlayerPrefs and update the text
        int score = PlayerPrefs.GetInt("CurrentScore", 0);
        scoreText.text = "Score: " + score;
    }

    private void UpdateScoreText()
    {
        // Retrieve the score from PlayerPrefs and update the text
        int score = PlayerPrefs.GetInt("CurrentScore", 0);
        scoreText.text = "Score: " + score;
    }

    // Reset the score
    public void ResetScore()
    {
        // Reset the current score in PlayerPrefs
        PlayerPrefs.SetInt("CurrentScore", 0);
        PlayerPrefs.Save();
    }
}
