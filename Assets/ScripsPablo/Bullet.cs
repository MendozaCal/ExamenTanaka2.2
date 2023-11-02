using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    Transform Player;
    Rigidbody2D rb;
    void Start()
    {
        Player = FindAnyObjectByType<PlayerMove>().transform;
        rb = GetComponent<Rigidbody2D>();
        Shoot();
    }

    private void Shoot()
    {
        Vector2 directionPlayer = (Player.position - transform.position).normalized;
        rb.velocity = directionPlayer * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<StunePlayer>().Stun(other.GetContact(0).normal);
            Destroy(gameObject);
        }
    }
}
