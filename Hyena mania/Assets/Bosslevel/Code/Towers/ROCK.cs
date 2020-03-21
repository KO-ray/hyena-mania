using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROCK : MonoBehaviour
{
    
    bool isShot;
    public GameObject enemy;
    public float shootSpeed;
    public Vector3 shoot;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        //Offset
        transform.LookAt(enemy.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //look at enemy
       
        //translate to shoot object
        transform.Translate(shoot* shootSpeed * Time.deltaTime);
       
    }
}
