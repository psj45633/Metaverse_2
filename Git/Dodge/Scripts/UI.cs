using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject endPanel;
    private float score = 0;
    private float timer = 0f;

    void Start()
    {
        endPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        score = timer;
        scoreText.text = $"Score: {Mathf.FloorToInt(score)}";
        score = Mathf.FloorToInt(score);
    }


    public void Restart()
    {
        SceneManager.LoadScene("Dodge");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Home");
    }


}
