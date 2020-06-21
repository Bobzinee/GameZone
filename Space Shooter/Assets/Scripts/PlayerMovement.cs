using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 mousePos;
    Vector2 lookDir;
    private Vector3 offset;
    //Offset distance for enemy to be spawned.
    public GameObject enemy;
    public static int playerScore;

    private void Start()
    {
        InvokeRepeating("SpawnEnemies", 3f, Random.Range(1f, 2f));
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = new Vector3(Random.Range(-16f, 16f), Random.Range(-16f, 16f), 0f);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    private void SpawnEnemies()
    {
        //Spawn enemies
        Instantiate(enemy, transform.position + offset, Quaternion.identity);
        Instantiate(enemy, transform.position - offset, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Game Over");
        }
    }
}
