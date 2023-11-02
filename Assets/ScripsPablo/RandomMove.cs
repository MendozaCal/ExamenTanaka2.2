using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    [SerializeField] private float Speed;
    private Vector2 RandomPosition;
    private float Distance = 2f;
    private Vector2 InicialPoint;
    private bool Movceenmy = true;
    private float timer;

    private void Start()
    {
        InicialPoint = transform.position;
        Direccion();
    }
    void Update()
    {
        timer += Time.deltaTime;
        Move();
        
        StartCoroutine(VegetablesMove());
    }
    private void Direccion()
    {
        float X = Random.Range(-5, 5);
        float Y = Random.Range(-5, 5);
        Vector2 RandomValue = new Vector2(X, Y);
        RandomPosition = InicialPoint + RandomValue * Distance;
    }
    private void MoveENmytrue()
    {
        enabled = true;
    }
    private void Move()
    {
        if (Movceenmy) // || Moveceenmy == false
        {
            transform.position = Vector2.MoveTowards(transform.position, RandomPosition, Speed * Time.deltaTime);
            if (timer > 2)
            {
                if (Vector2.Distance(transform.position, InicialPoint) > 1)
                {
                    Movceenmy = false;
                    timer = 0;
                    Direccion();
                }
            }

        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, RandomPosition, Speed * Time.deltaTime);
            if (timer > 2)
            {
                if (Vector2.Distance(transform.position, RandomPosition) > 1)
                {
                    Movceenmy = false;
                    timer = 0;
                    Direccion();
                }
            }
        }
    }
    IEnumerator VegetablesMove()
    {
        yield return new WaitForSeconds(5);
        MoveENmytrue();
    }
}
