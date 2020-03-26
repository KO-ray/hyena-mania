using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        print("cock and balls");

        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
