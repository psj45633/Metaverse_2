using UnityEngine;

public class Bullet : MonoBehaviour
{

    // 변수/ 총알 속도 방향 총알생성위치
    public float speed = 5f;
    public float angle = 0f;
    private Vector2 moveDirection;
    Rigidbody2D rb;

    public enum Spawn
    {
        Left, Right, Top, Bottom
    }
    public Spawn spawn;

    private void Awake()
    {
        if(rb == null) rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Vector3 spawnPosition = Vector3.zero;
        Vector2 initialDirection = Vector2.zero;

        switch (spawn)
        {
            case Spawn.Left:
                spawnPosition.x = -18f;
                spawnPosition.y = Random.Range(-10f, 10f);
                initialDirection += Vector2.right;
                break;
            case Spawn.Right:
                spawnPosition.x = 18f;
                spawnPosition.y = Random.Range(-10f, 10f);
                initialDirection += Vector2.left;
                break;
            case Spawn.Top:
                spawnPosition.y = 10f;
                spawnPosition.x = Random.Range(-18f, 18f);
                initialDirection += Vector2.down;
                break;
            case Spawn.Bottom:
                spawnPosition.y = -10f;
                spawnPosition.x = Random.Range(-18f, 18f);
                initialDirection += Vector2.up;
                break;
        }

        transform.position = spawnPosition;

        
        float randomAngle = Random.Range(-angle, angle);
        Quaternion rotation = Quaternion.Euler(0, 0, randomAngle);
        moveDirection = rotation * initialDirection;

        
        if (rb != null)
        {
            rb.velocity = moveDirection * speed;
        }


    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Debug.Log(collision.transform.position);

        if (collision.CompareTag("Player"))
        {
            DodgeManager.Instance.GameOver();
        }
    }



    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("Collision" + collision.gameObject.name);
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        DodgeManager.Instance.GameOver();
    //        Debug.Log("???");
    //    }

    //    if (collision.gameObject.CompareTag("Wall"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}




}
