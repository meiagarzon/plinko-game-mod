using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    public int score = 0;

    public void Start()
    {
        UpdateScoreDsiplay();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreDsiplay();
    }

    public void UpdateScoreDsiplay()
    {
        scoreDisplay.text = $"SCORE: {score}";
    }
}
