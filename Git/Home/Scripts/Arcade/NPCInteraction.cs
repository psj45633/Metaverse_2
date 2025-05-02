using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    //Rigidbody2D rb;

    private void Awake()
    {
        //rb = FindObjectOfType<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Debug.Log(collision.transform.position);

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("collision");
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("interaction");
            }
        }
    }
}
