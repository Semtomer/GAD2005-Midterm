using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // UI Text object to display the score

    private int score = 0; // Score variable

    // Method to increase the score
    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("score: " + score);
    }

    // Method to decrease the score
    public void DecreaseScore(int amount)
    {
        score -= amount;
        if (score < 0)
            score = 0;
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
}
