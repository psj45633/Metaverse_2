using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyPlanePlayGame : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("FlappyPlane");
    }
    public void Exit()
    {
        SceneManager.LoadScene("HomeScene");
    }
    public void ExitStartScene()
    {
        SceneManager.LoadScene("FlappyPlaneStart");
    }
}
