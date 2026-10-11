using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    public static Score Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        score = 0;
        scoreText.text = "Score: " + score;
        
    }

    public void UpdateScoreText(bool isDestroyed)
    {
        if (isDestroyed)
        {
            score += 10;
            scoreText.text = "Score: " + score;
            isDestroyed = false;
        }
    }
}
