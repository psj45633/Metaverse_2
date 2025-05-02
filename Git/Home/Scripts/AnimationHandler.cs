using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int isMoving = Animator.StringToHash("isMove");

    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }
    public void Move(Vector2 obj)
    {
        // 이동 방향 벡터의 크기를 이용해 움직이는 중인지 판단
        animator.SetBool(isMoving, obj.magnitude > .5f);
    }
}
