using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnemies : MonoBehaviour
{
    public GameObject normalEnemy;
    // public GameObject bossEnemy;
    public GameObject smallerEnemy;
    public GameObject explodingEnemy;
    private Vector3 offset;
    public Transform player;
    private Vector3 distance;
    private float spawnTimeNormal;
    private float spawnTimeExplode;
    private float spawnTimeSmall;
    // public PlayerMovement score;


    private void Start()
    {
        spawnTimeNormal = Random.Range(1f, 2f);
        spawnTimeSmall = Random.Range(3f, 6f);
        spawnTimeExplode = Random.Range(6f, 8f);
        InvokeRepeating("SpawnNormalEnemy", 2f, spawnTimeNormal);
        InvokeRepeating("SpawnSmallerEnemy", 4f, spawnTimeSmall);
        InvokeRepeating("SpawnExplodingEnemy", 6f, spawnTimeExplode);
    }
    private void Update()
    {
        offset = new Vector3(Random.Range(-16f, 16f), Random.Range(-16f, 16f), 0f);
        distance = transform.position + offset;
        checkDistance();
        if (PlayerMovement.playerScore > 70)
        {
            spawnTimeNormal = 1.2f;
            spawnTimeSmall = 3f;
            spawnTimeExplode = 6f;
        }
        if (PlayerMovement.playerScore > 140)
        {
            spawnTimeNormal = 0.8f;
            spawnTimeSmall = 2f;
            spawnTimeExplode = 5f;
        }
    }

    private void SpawnNormalEnemy()
    {
        Instantiate(normalEnemy, distance, transform.rotation);
    }

    private void SpawnExplodingEnemy()
    {
        Instantiate(explodingEnemy, distance, transform.rotation);
    }

    public void SpawnBoss()
    {
        //Spawn boss
    }

    private void SpawnSmallerEnemy()
    {
        Instantiate(smallerEnemy, distance, transform.rotation);
    }
    private void checkDistance()
    {
        float checkDist = Mathf.Abs(Vector3.Distance(player.position, distance));
        if (checkDist < 6f)
        {
            distance = distance * 6;
        }
    }
}
