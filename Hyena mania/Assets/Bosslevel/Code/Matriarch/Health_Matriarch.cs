using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Matriarch : MonoBehaviour
{
    public float enemyHealth;

    public void DoDamg(float f)
    {
        
        
      if (enemyHealth <= f)
      {
         Destroy(gameObject);

      }
      else
      {
        enemyHealth -= f;
                
      }
       


    }
}
