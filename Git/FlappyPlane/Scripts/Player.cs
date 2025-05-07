using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;

    public float flapForce = 6f;
    public float forwardSpeed = 3f;
    public bool isDead = false;
    float deathCooldown = 0f;

    bool isFlap= false;
    public bool godMode = false;

    GameManager_Flappy gameManager;
    void Start()
    {
        gameManager = GameManager_Flappy.Instance;
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();

        if (animator == null) Debug.LogError("Not Founded Animator");
        if (rb == null) Debug.LogError("Not Founded Rigidbody");
    }

    
    void Update()
    {
        if (isDead)
        {
            if(deathCooldown <= 0)
            {
                if (Input.GetKeyDown(KeyCode.Space) | Input.GetMouseButtonDown(0))
                {
                    gameManager.RestartGame();
                }
            }
            else
            {
                deathCooldown -= Time.deltaTime;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) | Input.GetMouseButtonDown(0))
            {
                isFlap = true;
            }
        }
    }

    private void FixedUpdate()
    {
        if (isDead) return;

        Vector3 velocity = rb.velocity;
        velocity.x = forwardSpeed;

        if (isFlap)
        {
            velocity.y += flapForce;
            isFlap= false;
        }
        rb.velocity = velocity;

        float angle = Mathf.Clamp((rb.velocity.y * 1), -30, 30);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (godMode) return;

        if (isDead) return;

        isDead = true;
        deathCooldown = 1f;

        animator.SetInteger("IsDie",1);

        gameManager.GameOver();
    }
}
