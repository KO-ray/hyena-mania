using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_BossLevel : MonoBehaviour
{
    public GameObject enemy;
    public float range;
    private float distanceToEnemy;

    public Vector3 shoot;

    public float coolDown;
    public float currentCoolDown;

    public float shootSpeed;
    public GameObject rock;

    bool isShot;
    bool canSpawn;

    // Start is called before the first frame update
    void Start()
    {
        canSpawn = false;
        enemy = GameObject.FindGameObjectWithTag("Enemy");
       
        isShot = false;

        currentCoolDown = coolDown; 

    }

    // Update is called once per frame
    void Update()
    {
        currentCoolDown -= Time.deltaTime;

        distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);

        if (distanceToEnemy <= range && canSpawn) 
        {
           
            ShootRock();
            canSpawn = false;
        }
        if (currentCoolDown <= 0)
        {
            
            currentCoolDown = coolDown;
            canSpawn = true;
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
        GameObject currentRock = Instantiate(rock, transform.position, Quaternion.identity);
        //look at enemy
        // currentRock.transform.LookAt(enemy.transform);
        //translate to shoot object
        //currentRock.transform.Translate(shoot * Time.deltaTime * shootSpeed);
        isShot = true;

    }
   void OnTriggerEnter(Collider other)
    {
        //check bool
        if (isShot)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("BULLSEYE");         
            }
        }
        //DoDamage
    }
}
