using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject explosionEffect;
    private void Update()
    {
        Destroy(gameObject, 3f);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }


    }
}
