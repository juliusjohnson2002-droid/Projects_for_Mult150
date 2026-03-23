using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      int health = 500;

      health = 50; 

      if (health <=0)
        {
            Debug.Log("over");
        }
        else if (health<100)
        {
        Debug.Log("low health");
        }
        else
        {
            Debug.Log("zero");
        }
      //  Debug.Log (health);
  //  Debug.Log ( health-=poisonDamage );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//       float health = 1004f;
       // float poisonDamage = 125.5f;

//for ( health = health; health >= poisonDamage ;health ++)
       // {
    //        Debug.Log( health )


    // while (health>=0)
       // {
       //    health = health - poisonDamage;
       //    health--;
       // }
       // Debug.Log(health);