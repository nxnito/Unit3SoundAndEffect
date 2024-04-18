using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    private int randomObstacle;
  
    void Start()
    {
       playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
       InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles ()
    {
        if (playerControllerScript.gameOver == false)
        {
            randomObstacle = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[randomObstacle], spawnPos, obstaclePrefabs[randomObstacle].transform.rotation); ;
        }
    }
}

