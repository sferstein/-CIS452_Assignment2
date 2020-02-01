using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Spawner.cs
 * Assignment 2
 * This controls the spawning of the asteroids.
 */

public class Spawner : MonoBehaviour
{
    public GameObject[] asteroidPrefab;
    private GameManager gameManager;
    private float spawnPosZ = 5;
    private float delay = 0.5f;
    private float spawnRangeX = 6;
    private float spawnInterval = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAsteroid", delay, spawnInterval);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnAsteroid()
    {
        if (gameManager.isGameActive)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int asteroidIndex = Random.Range(0, asteroidPrefab.Length);

            Instantiate(asteroidPrefab[asteroidIndex], spawnPos,
                asteroidPrefab[asteroidIndex].transform.rotation);
        }
    }
}
