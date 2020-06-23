using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject explosionEffect;
    public GameObject smallerExp;
    private Shake shake;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }
    private void Update()
    {
        Destroy(gameObject, 3f);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            shake.CamShake();
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(explosionEffect, transform.position, transform.rotation);

            //Incrementing player score.
            PlayerMovement.playerScore++;
        }

        if (other.gameObject.CompareTag("SmallerEnemy"))
        {
            shake.CamShake();
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(smallerExp, transform.position, transform.rotation);

            //Incrementing player score.
            PlayerMovement.playerScore++;
        }
    }
}
