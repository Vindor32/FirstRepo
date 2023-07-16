using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int damage = 25;
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    public float lifetime = 2f;

    void Start ()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);

    }

    void Awake ()
    {
        Destroy(gameObject, lifetime);
    }
}
