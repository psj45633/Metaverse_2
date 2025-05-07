using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Dodge : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI endResultText;
    public GameObject endPanel;
    public float bestScore;
    public const string BestScoreKey = "DodgeBestScore";

    public float score = 0;
    private float timer = 0f;

    void Start()
    {

        endResultText.text = $"Score : {score}\nGold : {score}";
        endPanel.SetActive(false);
        bestScore = PlayerPrefs.GetFloat(BestScoreKey, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        score = timer;
        scoreText.text = $"Score : {Mathf.FloorToInt(score)}";
        bestScoreText.text = $"Best : {Mathf.FloorToInt(bestScore)}";
        score = Mathf.FloorToInt(score);
    }


    public void Restart()
    {
        SceneManager.LoadScene("Dodge");
    }

    public void Exit()
    {
        SceneManager.LoadScene("DodgeStart");
        Time.timeScale = 1.0f;
    }

    public void UpdateScore()
    {
        if( score > bestScore)
        {
            bestScore = score;

            PlayerPrefs.SetFloat(BestScoreKey, bestScore);
        }
    }


}
