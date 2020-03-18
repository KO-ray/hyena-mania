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
       enemy = GameObject.FindGameObjectWithTag("Enemy");
       

    }

    // Update is called once per frame
    void Update()
    {
        distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

        transform.LookAt(enemy.transform);

        if (distanceToEnemy <= range)
        {
            ShootRock();
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    void ShootRock()
    {
        //instantiate rock
        //look at enemy
        //translate to shoot object
        //MAKE ROCK TRIGGER
        
    }
   void OnTriggerEnter(Collider other)
    {
        //check bool
        //DoDamage
    }
}
