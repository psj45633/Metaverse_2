using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    

    //private void Awake()
    //{
        
    //}
    //void Start()
    //{
        
    //}

    
    //void Update()
    //{
        
    //}

    protected virtual void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        

        
    }
}
