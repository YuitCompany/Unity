using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score, highScore;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GetScore"))
        {
            score += 1;
        }
    }

    public void SetScore(int _score) { score = _score; }
    public void SetHighScore()
    {
        if (highScore < score)
        {
            highScore = score;
            score = 0;

            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }
    public int GetScore() { return score; }
    public int GetHighScore() { return highScore; }
}
