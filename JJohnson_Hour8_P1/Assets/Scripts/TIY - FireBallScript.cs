using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIYFireBallScript : MonoBehaviour

{
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
    // Start is called before the first frame update
    void Start()
  {
    
  }
    // Update is called once per frame
    void Update()
    {
        
    }
}

