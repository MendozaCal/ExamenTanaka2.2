using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootHaba: MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefap;
    [SerializeField]
    float time;
    void Start()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(bulletPrefap, transform.position, Quaternion.identity);
        }
    }
}
