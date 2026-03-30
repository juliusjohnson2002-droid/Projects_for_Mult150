
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIY_calling_Method : MonoBehaviour
{
    // Start is called before the first frame update
    int TakeDamageFromFireball()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }
    int TakeDamageFromFireball (int damage)
    {
      int playerHealth = 100;
        return playerHealth - damage;
    }
    int TakeDamageFromFireball (int playerHealth, int damage)
    {
        return playerHealth - damage;
    }
    void Start()
    {
     
       int x = TakeDamageFromFireball();
       Debug.Log ("player health: "+ x );

       int y = TakeDamageFromFireball(25);
       Debug.Log ("player health: " + y);

       int z = TakeDamageFromFireball(30,50);
      Debug.Log ("player health: " + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   /*
    void TakeDamageFromFireball(int damage, int playerHealth)
    {
         int TakeDamage(int damage , int playerhealth) ;
      {
       

        int playerhealth = 100;
        return playerHealth - damage;
    }
    }*/
}