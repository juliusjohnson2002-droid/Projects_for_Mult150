using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameControlScrript control;
    public GameObject obstacle;
    public GameObject powerup;

    float totalTimeElapsed = 0;
    float spawnCycle = .5f;
    bool spawnPowerup = true;
    void Start()
    {
       control = GetComponent<GameControlScrript>(); 
    }


    // Update is called once per frame
    void Update()
    {
        totalTimeElapsed +=Time.deltaTime;
        if(totalTimeElapsed > spawnCycle)
        {
            GameObject temp;
            if(spawnPowerup)
            {
              temp = Instantiate(powerup) as GameObject;
            }
            else
            {
             	temp = Instantiate(obstacle) as GameObject;
            }
            totalTimeElapsed -= spawnCycle;
            spawnPowerup = !spawnPowerup;
        }
    }
}
