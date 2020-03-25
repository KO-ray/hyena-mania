using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float coolDown;
    public float counter;
    public Text WaveCountdownText;

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;

        if (counter <= 0f)
        {
            coolDown ++;
            counter = coolDown;

            Instantiate(enemyPrefab, transform.position, transform.rotation);
            print("You hear maniacal laughing");
        }
    }
}
