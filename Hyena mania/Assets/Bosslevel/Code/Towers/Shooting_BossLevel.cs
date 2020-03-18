using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_BossLevel : MonoBehaviour
{
    public GameObject enemy;
    public float range;
    private float distanceToEnemy;

    // Start is called before the first frame update
    void Start()
    {
       enemy = GameObject.Find("Enemy");
       distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(enemy.transform);

        if (distanceToEnemy <= range)
        {
            Debug.Log(distanceToEnemy);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
