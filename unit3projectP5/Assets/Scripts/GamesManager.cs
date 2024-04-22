using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesManager : MonoBehaviour
{
    public float score;
    private PlayerController playerControllerScript;
    void Start()
    {
     playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerControllerScript.gameOver)
        {
            if(playerControllerScript.doubleSpeed)
            {
                score += 2;
            }
            else
            {
                score++;
            }
            Debug.Log("Score: " + score);
        }
    }
}
