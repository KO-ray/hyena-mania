using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves;
    public float countdown;
    public float coolDown;

    public Text WaveCountdownText;

    public int waveIndex = 0;

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(Spawnwave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        WaveCountdownText.text = Mathf.Floor(countdown).ToString();
    }

    IEnumerator Spawnwave()
    {
        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(coolDown);
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        print("You hear maniacal laughing");
    }  
}
