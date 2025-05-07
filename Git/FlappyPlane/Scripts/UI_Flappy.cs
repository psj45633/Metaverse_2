using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Flappy : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;
    public TextMeshProUGUI bestScoreText;

    GameManager_Flappy gameManager;

    void Start()
    {
        gameManager = GameManager_Flappy.Instance;
        if (restartText == null) Debug.LogError("restart text is null");
        if (scoreText == null) Debug.LogError("socre text is null");

        restartText.gameObject.SetActive(false);
        gameManager.bestScore = PlayerPrefs.GetInt("FlappyBestScore", 0);
        bestScoreText.text = $"Best : {gameManager.bestScore.ToString()}";
    }

    public void SetRestart()
    {
        restartText.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {     
        scoreText.text = score.ToString();
    }
}
