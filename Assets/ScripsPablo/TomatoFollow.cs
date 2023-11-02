using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoFollow : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    float Distance;

    private void Update()
    {
        Distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        if (Distance < 5)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        }
    }
}
