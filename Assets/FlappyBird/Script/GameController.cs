using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button play;
    public Text score, highScore, youScore;

    public int gameMode;

    public BirdManager birdManager;
    public ScoreManager scoreManager;

    private void Start()
    {
        birdManager.ResetGame();
        gameMode = 0;

        play.gameObject.SetActive(true);
        highScore.gameObject.SetActive(true);
        score.gameObject.SetActive(false);
        youScore.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(!birdManager.status)
        {
            gameMode = 0;

            play.gameObject.SetActive(true);
            highScore.gameObject.SetActive(true);
            score.gameObject.SetActive(false);
            youScore.gameObject.SetActive(true);

            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            if (gameMode != 2) return;
            gameMode = 1;
            birdManager.StartGame();
        }

        score.text = scoreManager.GetScore().ToString();
        if(scoreManager.GetScore() != 0) youScore.text = "Score: " + scoreManager.GetScore().ToString();
        highScore.text = "The Best: " + scoreManager.GetHighScore().ToString();
    }

    public void Playgame()
    {
        birdManager.ResetGame();
        gameMode = 2;
        Time.timeScale = 1;

        play.gameObject.SetActive(false);
        highScore.gameObject.SetActive(false);
        score.gameObject.SetActive(true);
        youScore.gameObject.SetActive(false);
    }

    public int GameMode() { return gameMode; }
}
