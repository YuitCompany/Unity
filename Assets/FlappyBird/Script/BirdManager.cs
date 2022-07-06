using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{
    public bool status;

    float jumpspace;

    public Rigidbody2D rb;
    public MusicManager musicManager;
    public ScoreManager scoreManager;
    public GameController gameController;

    void Start()
    {

        status = true;
        scoreManager.SetScore(0);
        jumpspace = 6;
        rb.gravityScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            if (gameController.GameMode() != 1) return;
            Jump();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Dead();
        }
    }

        
    void Jump()
    {
        musicManager.PlayFlapMusic();
        rb.velocity = new Vector2(0, jumpspace);
    }

    void Dead()
    {
        status = false;
        musicManager.PlayFallMusic();
        scoreManager.SetHighScore();
    }

    public void ResetGame()
    {
        rb.gravityScale = 0;
        rb.transform.position = new Vector3(-5, 0, 0);
        rb.velocity = Vector2.zero;
        status = true;
        scoreManager.SetScore(0);
    }

    public void StartGame()
    {
        rb.gravityScale = 2;
    }
}
