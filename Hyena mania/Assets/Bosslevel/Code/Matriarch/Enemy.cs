using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    public float speed;

    private Transform target;
    public float targetRange;
    private int wavepointIndex = 0;

    private Vector3 dir;
    public NavMeshAgent agent;

    [Header("Attack")]
    public float timerAmount;
    public float damageRadius;
    public float damageAmount;
    float currentTimer;
    Animator animator;


    void Start()
    {
        target = Waypoints.points[0];
        currentTimer = timerAmount;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(currentTimer <= 0)
        {
            currentTimer = timerAmount;
            Attack();
        }
       
        currentTimer -= Time.deltaTime;
       
        if(target != Waypoints.points[Waypoints.points.Length - 1])
        {
            agent.SetDestination(target.position);

            if (Vector3.Distance(agent.transform.position, target.position) <= targetRange)
            {
                GetNextWaypoint();
            }
        }
        else
        {
            //game over
            Debug.Log("game over");
        }      
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        //damage is radius
        Collider[] coll = Physics.OverlapSphere(agent.transform.position, damageRadius);

        foreach (var tower in coll)
        {
            if (tower.gameObject.CompareTag("Tower"))
            {
                //do damage
            }
        }
    }

    void GetNextWaypoint() 
    {
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
       // Gizmos.DrawWireSphere(agent.transform.position, damageRadius);
    }
}
