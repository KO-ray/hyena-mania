using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROCK : MonoBehaviour
{
    
    //bool isShot;
    public GameObject enemy;
    public float shootSpeed;
    public Vector3 shoot;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        //Offset
       
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(enemy.transform);
        //translate to shoot object
        transform.Translate(shoot* shootSpeed * Time.deltaTime);

       
    }

    void OnTriggerEnter(Collider rockHit)
    {
        if (rockHit.gameObject.CompareTag("Enemy"));
        {
            //Do damage 
            print("hit!");

            Destroy(gameObject);
        }
        
    }
}
