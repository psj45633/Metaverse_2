using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReaderBoard : MonoBehaviour
{
    public TextMeshProUGUI Dodge;
    public TextMeshProUGUI Flappy;
    private float dodgeBestScore;
    private int FlappyBestScore;


    private void Start()
    {
        dodgeBestScore = PlayerPrefs.GetFloat("DodgeBestScore", 0);
        Dodge.text =  $"Dodge\r\nBest\r\nScore  {Mathf.FloorToInt(dodgeBestScore)}";

        FlappyBestScore = PlayerPrefs.GetInt("FlappyBestScore", 0);
        Flappy.text = $"FlappyPlane\r\nBest\r\nScore  {Mathf.FloorToInt(FlappyBestScore)}";

    }

}
