using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject spawn;
    private GameObject tower;
    public Vector3 positionOffset;
    
    public void OnMouseDown()
    {
        //if there's already a turret, you can't buil here
        if (tower != null)
        {
            Debug.Log("Tower already build--On screen");
            return;
        }
        
        //Build tower
        GameObject towerToBuild = BuildManager.instance.GetTowerToBuild();
        tower = (GameObject)Instantiate(towerToBuild, spawn.transform.position + positionOffset, spawn.transform.rotation);
    }

    public void OnMouseEnter()
    {
        //Switches matrial emission on 
        gameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }

    public void OnMouseExit()
    {
        //Switches material emission off
        gameObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
}