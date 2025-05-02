using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    
    private Camera playerCamera;
    


    
    protected override void Start()
    {
        base.Start();
        playerCamera = Camera.main;
    }

    

    protected override void HandleAction()
    {
        // Ű���� �Է��� ���� �̵� ���� ��� (��/��/��/��)
        float horizontal = Input.GetAxisRaw("Horizontal"); // A/D �Ǵ� ��/��
        float vertical = Input.GetAxisRaw("Vertical"); // W/S �Ǵ� ��/��

        // ���� ���� ����ȭ (�밢���� �� �ӵ� ����)
        movementDirection = new Vector2(horizontal, vertical).normalized;

        // ���콺 ��ġ�� ȭ�� ��ǥ �� ���� ��ǥ�� ��ȯ
        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPos = playerCamera.ScreenToWorldPoint(mousePosition);
        lookDirection = (worldPos - (Vector2)transform.position);

        // ���� ��ġ�κ��� ���콺 ��ġ������ ���� ���
        if (lookDirection.magnitude < .9f)
        {
            lookDirection = Vector2.zero;
        }
        else
        {
            lookDirection = lookDirection.normalized;
        }
    }
}