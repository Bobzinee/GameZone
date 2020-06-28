using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    private int damage = 0;
    public Color color1;
    public Color color2;
    public GameObject explosionEffect;
    private SpriteRenderer spriteRend;
    private float lerpTime = 0.5f;

    private void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            damage++;
        }

        switch (damage)
        {
            case 1:
                spriteRend.color = Color.Lerp(spriteRend.color, color1, lerpTime);
                break;
            case 2:
                spriteRend.color = Color.Lerp(spriteRend.color, color2, lerpTime);
                break;
            case 3:
                Instantiate(explosionEffect, transform.position, transform.rotation);
                Destroy(gameObject);
                break;
        }
    }
}
