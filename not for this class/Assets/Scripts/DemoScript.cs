using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      int health;
      health = 100;

      int potion = 20;

      health = health - 30;
      health = health + potion;

      Debug.Log("health is " +health);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
