using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab to spawn
    public float spawnRate = 2f; // Time interval between spawns
    public float spawnRadius = 5f; // Maximum distance from spawn point

    private float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = Time.time + spawnRate;
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void SpawnEnemy()
    {
        // Randomly determine spawn position within spawnRadius
        Vector2 randomPosition = Random.insideUnitCircle * spawnRadius;
        Vector3 spawnPosition = transform.position + new Vector3(randomPosition.x, randomPosition.y, 0);

        // Debug log to verify spawn position
        Debug.Log("Spawning enemy at: " + spawnPosition);

        // Spawn enemy prefab at the calculated position
        GameObject spawnedEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        // Debug log to verify if the enemy was instantiated
        if (spawnedEnemy != null)
        {
            Debug.Log("Enemy spawned successfully.");
        }
        else
        {
            Debug.LogError("Failed to spawn enemy.");
        }
    }
}