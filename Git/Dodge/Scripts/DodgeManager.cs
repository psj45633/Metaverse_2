
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class DodgeManager : MonoBehaviour
{
    public static DodgeManager Instance;
    public GameObject bulletPrefab;
    public float spawnInterval = 0.05f;
    
    UI ui;
    
    

    public float leftSpawnX = -18f;
    public float rightSpawnX = 18f;
    public float topSpawnY = 10f;
    public float bottomSpawnY = -10f;



    private void Awake()
    {
        Time.timeScale = 1f;
        Instance = this;
        ui = FindObjectOfType<UI>();
        if (ui == null) Debug.Log("null");
        
    }
    void Start()
    {
        InvokeRepeating("MakeBullet", 0f, spawnInterval);
    }

    

    private void MakeBullet()
    {
        int randomWall = Random.Range(0, 4);
        GameObject newBullet = Instantiate(bulletPrefab);
        Bullet bullet = newBullet.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.angle = 30f;

            switch (randomWall)
            {
                case 0:
                    bullet.spawn = Bullet.Spawn.Left;
                    break;
                case 1:
                    bullet.spawn = Bullet.Spawn.Right;
                    break;
                case 2:
                    bullet.spawn = Bullet.Spawn.Top;
                    break;
                case 3:
                    bullet.spawn = Bullet.Spawn.Bottom;
                    break;
            }
        }
    }

    public void GameOver()
    {
        ui.UpdateScore();
        ui.endPanel.SetActive(true);
        ui.endResultText.text = $"Score : {ui.score}\nGold : {ui.score}";
        Time.timeScale = 0f;

        //ui.bestScoreText;
        //if (PlayerPrefs.HasKey("ui.bestScoreText"))
        //{
        //    float best = PlayerPrefs.GetFloat("ui.bestScoreText");
        //    if(best < ui.score)
        //    {
        //        PlayerPrefs.SetFloat("ui.bestScoreText", ui.score);
        //        ui.bestScoreText = (string)Mathf.FloorToInt(ui.score).;
        //    }
        //}
        




    }

    
}