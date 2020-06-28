using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private Transform target;
    private float speed = 3f;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (gameObject.CompareTag("SmallerEnemy"))
        {
            speed = 6f;
        }
        if (gameObject.CompareTag("ExplodingEnemy"))
        {
            speed = 1.5f;
        }
    }

    private void Update()
    {
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

    }
}
