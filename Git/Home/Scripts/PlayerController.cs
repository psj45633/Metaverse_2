using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PlayerController : BaseController
{
    private Camera playerCamera;
    public GameObject riding;

    protected override void Start()
    {
        base.Start();
        playerCamera = Camera.main;
    }

    protected override void HandleAction()
    {
        // 키보드 입력을 통해 이동 방향 계산 (좌/우/상/하)
        float horizontal = Input.GetAxisRaw("Horizontal"); // A/D 또는 ←/→
        float vertical = Input.GetAxisRaw("Vertical"); // W/S 또는 ↑/↓

        // 방향 벡터 정규화 (대각선일 때 속도 보정)
        movementDirection = new Vector2(horizontal, vertical).normalized;

        // 마우스 위치를 화면 좌표 → 월드 좌표로 변환
        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPos = playerCamera.ScreenToWorldPoint(mousePosition);
        lookDirection = (worldPos - (Vector2)transform.position);

        // 현재 위치로부터 마우스 위치까지의 방향 계산
        if (lookDirection.magnitude < .9f)
        {
            lookDirection = Vector2.zero;
        }
        else
        {
            lookDirection = lookDirection.normalized;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            riding.gameObject.SetActive(!riding.gameObject.activeSelf);
        }
    }

    protected override void Movement(Vector2 direction)
    {
        base.Movement(direction);
        if (riding != null && riding.activeSelf)
        {
            direction *= 10f;
            _rigidbody.velocity = direction;
        }
    }

    
}