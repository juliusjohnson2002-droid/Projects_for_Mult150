using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BIrthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      {
      for (int day = 1; day <= 31; day ++ )
        {
                if (day ==17)
                {
                   print( day +"Its my birthday!");
            }
            
          else 
                {
                    print (day);
                }
        }
    }
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
