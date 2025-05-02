using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    float offSetX;
    float offSetY;

    void Start()
    {
        if (target == null) return;

        offSetX = transform.position.x - target.position.x;
        offSetY = transform.position.y - target.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        Vector3 pos = transform.position;

        pos.x = target.position.x + offSetX;
        pos.y = target.position.y + offSetY;
        transform.position = pos;
    }
}


