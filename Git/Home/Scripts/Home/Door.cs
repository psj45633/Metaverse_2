using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 targetPosition;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Come in");
            ComeIn(collision.gameObject);
        }
    }

    private void ComeIn(GameObject gameObject)
    {
        gameObject.transform.position = targetPosition;
    }
}
