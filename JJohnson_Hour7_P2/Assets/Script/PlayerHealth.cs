using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       float health = 1004f;
    float poisonDamage = 125.5f;

   for (int health ; health<=12;health = health -= poisonDamage)
        {
           if(health>6)
           {
            Debug.Log(health);
           
           }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 //while (health >= 0)
       // {
          //  health = health - poisonDamage;
          //  health--;
      //  }
     // Debug.Log(health);
   // }
   // float health = 1004f;
   // float poisonDamage = 125.5f;