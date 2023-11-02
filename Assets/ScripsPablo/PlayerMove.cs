using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canMove = true;
    [SerializeField]
    Vector2 velocityrebound;
    [Header("-----Movimiento-----")]
    [SerializeField]
    private float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }
    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horizontal, vertical) * speed;
    }
    public void Rebote(Vector2 puntoGolpe)
    {
        rb.velocity = new Vector2(-velocityrebound.x * puntoGolpe.x, -velocityrebound.y * puntoGolpe.y);
    }
}
