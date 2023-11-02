using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDetection : MonoBehaviour
{
    public GameObject Player;
    public float speed;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Tomate") && collision.gameObject.CompareTag("Player"))
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
