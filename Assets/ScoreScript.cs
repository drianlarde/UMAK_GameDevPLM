using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject highScoreObject;
    int highScore;

    void Awake()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        highScoreText.text = "High Score: " + highScore;
    }

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void showScore()
    {
        gameObject.SetActive(true);
    }

    public void showHighScore()
    {
        highScoreObject.LeanScale(Vector2.one * 3, 0.1f).setEaseInCubic();
    }

    public void hideHighScore()
    {
        highScoreObject.LeanScale(Vector2.zero, 0.1f).setEaseInCubic();
    }

    public void addScore()
    {
        int score = PlayerPrefs.GetInt("score");
        score++;
        PlayerPrefs.SetInt("score", score);
        scoreText.text = "" + score;

        if (score > highScore)
        {
            PlayerPrefs.SetInt("highScore", score);
            // Debug.Log("Set a new High Score!");

            highScoreText.text = "High Score: " + score;
        }
    }

    public void resetScore()
    {
        PlayerPrefs.SetInt("score", 0);
        scoreText.text = "0";
        gameObject.SetActive(false);
    }
}
