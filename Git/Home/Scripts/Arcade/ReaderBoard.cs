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
            Debug.LogError("UI ��ũ��Ʈ�� ã�� �� �����ϴ�!");
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
            Debug.LogError("UI ��ũ��Ʈ �Ǵ� bestScoreText�� null�Դϴ�!");
        }
    }

}
