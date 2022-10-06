using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    public float spawnXRange = 8;

    public float spawnYRange = 10;


    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 1, 2);
    }

    void SpawnRandomEnemy()
    {
        int index = Random.Range(0, enemyPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnXRange,spawnXRange), spawnYRange, 0);

        Instantiate(enemyPrefabs[index], spawnPos, enemyPrefabs[index].transform.rotation);
    }
}
