using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScrript : MonoBehaviour

{
    private float objectSpeed = -.3f;
    float minSpeed =-.15f;
    float maxSpeed = -.3f;

    public GroundScript ground;
    public GroundScript wall;
    public GroundScript wall2;
    float timeRemaining =10;
    float timeExtension =1.5f;
    float totalTimeElapsed = 0; 
    bool isGameOver =false;

    public float ObjectSpeed { get => objectSpeed; set => objectSpeed = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (isGameOver) 
     return;
     totalTimeElapsed += Time.deltaTime;
     timeRemaining -= Time.deltaTime;
     if (timeRemaining <=0)
     isGameOver=true;
    }
    
    public void SlowWorldDown()
    {
        CancelInvoke("speedWorldUp");
        
        ObjectSpeed = minSpeed;
        ground.SlowDown();
        wall.SlowDown();
        wall2.SlowDown();

        Invoke ("speedWorldUp", 1);
    }
    void SpeedWorldUp()
    {
        objectSpeed = maxSpeed;
        ground.SpeedUp();
        wall.SpeedUp();
        wall2.SlowDown();

        Invoke("SpeedWorldUp", 1);
    }

    public void PowerUpCollected()
    {
        timeRemaining += timeExtension;
        {
#pragma warning disable CS8321 // Local function is declared but never used
            void OnGUI()
            {
                if(!isGameOver)
                {
                GUI.Box(new Rect(Screen.width/2-50,Screen.height-100 ,100 ,50), "Time Remaining");
                GUI.Label(new Rect(Screen.width/ 2 - 10, Screen.height-80,20,40),((int)timeRemaining).ToString());
            }
            else
                {
                    GUI.Box( new Rect(Screen.width /2-60,Screen.height / 2 -100, 120, 50) , "Game Over");
                    GUI.Label(new Rect (Screen.width /2-55,Screen.height /2 - 80, 90, 40), "Total Time: " + (int)totalTimeElapsed);

                }

        }
#pragma warning restore CS8321 // Local function is declared but never used
        }
}

    internal void PowerupCollected()
    {
        throw new NotImplementedException();
    }
}
