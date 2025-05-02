using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReaderBoard : MonoBehaviour
{
    UI ui;
    public TextMeshProUGUI Dodge;
    public TextMeshProUGUI Flappy;

    private void Awake()
    {
        ui = FindObjectOfType<UI>();
        if (ui == null)
        {
            Debug.LogError("UI 스크립트를 찾을 수 없습니다!");
        }
    }
    private void Start()
    {
        if (ui != null && ui.bestScoreText != null)
        {
            Dodge.text = ui.bestScoreText.text;
        }
        else
        {
            Debug.LogError("UI 스크립트 또는 bestScoreText가 null입니다!");
        }
    }

}
