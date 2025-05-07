using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_Flappy : MonoBehaviour
{
    static GameManager_Flappy gameManager;
    public static GameManager_Flappy Instance { get { return gameManager; } }

    UI_Flappy uiManager;
    public UI_Flappy UIManager { get { return uiManager; } }

    public int currentScore = 0;
    public int bestScore;
    public const string BestScoreKey = "FlappyBestScore";



    private void Awake()
    {
        gameManager = this;
        uiManager = FindObjectOfType<UI_Flappy>();
    }

    private void Start()
    {
        uiManager.UpdateScore(0);
        bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
    }


    public void GameOver()
    {
        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt(BestScoreKey, bestScore);
        }
        uiManager.SetRestart();

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log("Score :"+currentScore);
        
        uiManager.UpdateScore(currentScore); 
    }
}
