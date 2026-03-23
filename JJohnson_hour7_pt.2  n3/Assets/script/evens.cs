using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       for (int number = 22; number<= 100; )
        {
                if (number ==100)
                {
                   print( number );
            }
            
          else 
                {
                   
                   number=number+0x2;
                   print (number);
                } 


    }
}

}