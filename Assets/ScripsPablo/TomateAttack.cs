using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomateAttack : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private float DistancePlayer;
    [SerializeField] private float DistanciaMin;
    [SerializeField] private float AreaDestruccion;
    [SerializeField] private float sPEED;
    [SerializeField] private GameObject enemy;
    void Update()
    {
        DistancePlayer = Vector2.Distance(transform.position, player.transform.position);

        if ((DistancePlayer < DistanciaMin) && gameObject.CompareTag("TomateEspecial"))
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, sPEED * Time.deltaTime);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, DistanciaMin);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AreaDestruccion);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("TomateEspecial") && collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            player.GetComponent<PlayerMove>().enabled = false;

            //enemy.GetComponent<Enemy>().enabled = false;
        }
    }
}
