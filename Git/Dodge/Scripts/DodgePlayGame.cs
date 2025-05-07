using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DodgePlayGame : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Dodge");
    }
    public void Exit()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
