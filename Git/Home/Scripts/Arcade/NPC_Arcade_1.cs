using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC_Arcade_1 : NPCInteraction
{
    public GameObject conversation;



    protected override void OnTriggerStay2D(Collider2D collision)
    {
        base.OnTriggerStay2D(collision);
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("collision");
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("interaction");
                conversation.gameObject.SetActive(true);
                //SceneManager.LoadScene("DodgeStart");
            }
        }
    }

    public void PlayDodge()
    {
        SceneManager.LoadScene("DodgeStart");
    }

    public void NoAnswer()
    {
        conversation.gameObject.SetActive(false);
    }
}
