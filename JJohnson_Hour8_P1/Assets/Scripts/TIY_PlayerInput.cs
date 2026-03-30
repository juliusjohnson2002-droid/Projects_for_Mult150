using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIY_PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame0
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");

        if (hVal !=0)
            Debug.Log("h movment: " +hVal);
        if (vVal !=0 )
            Debug.Log("v movement: " +vVal);
            
            
    }
}
