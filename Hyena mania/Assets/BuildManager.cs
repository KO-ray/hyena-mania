using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{//Start singleton
    public static BuildManager instance;//Stores the Buildmanager in a reference

     void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one Buildmanager in scene!");
            return;
        }
        instance = this; //referring to this script (There can now only be one Buildmanager)

    }
//End singleton

    private GameObject towerToBuild;

    public GameObject standardTowerPrefab;

    void Start()
    {
        towerToBuild = standardTowerPrefab;

    }
    public GameObject GetTowerToBuild()
    {
        return towerToBuild;

    }
}
