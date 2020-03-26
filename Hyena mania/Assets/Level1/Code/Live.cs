using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Live : MonoBehaviour
{
    public float LifeCounter;

    public void Update()
    {
        if (LifeCounter == 0)
        {
            SceneManager.LoadScene(1);
        }
        LifeCounter -= 1;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            print("OH YEAH BABEY");

            
        }
    }
}
