using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public Transform target;
    public GameObject rock;
    public float cooldown;
    public float currentCooldown;
    bool canSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
        currentCooldown = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        currentCooldown -= Time.deltaTime;
        if (currentCooldown <= 0 && target != null)
        {
            SpawnRock();
            currentCooldown = cooldown;
        }

    }

     void OnTriggerEnter(Collider other)
     {
          if (target = null)
          {
            target = other.transform;
          }
      }

   
    void SpawnRock()
    {
        //instantiate rock
        GameObject currentRock = Instantiate(rock, transform.position, Quaternion.identity);
    }

  
}
