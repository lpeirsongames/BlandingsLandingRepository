using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private float spawnRangeX = 12;
    private float spawnRangeY = 4;
    private float startDelay = 1;
    private float spawnInterval = 1;

    //I think it could be cool to have the seagull follow the player when it is on screen for like 5 seconds, instead of just flowing with the water since it is flying and not in the water and since its a main predator

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval); //starts spawning the obstacles repeatedly once the game starts
    }

    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length); 
        Vector2 spawnPos = new Vector2(spawnRangeX, Random.Range(-spawnRangeY, spawnRangeY));
        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   
}
