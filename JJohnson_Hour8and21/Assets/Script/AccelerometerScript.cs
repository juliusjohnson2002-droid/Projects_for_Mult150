using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float x = Input . acceleration.x * Time.deltaTime;
      float z = -Input . acceleration . z * Time.deltaTime;
      transform.Translate (x,0f, z);
    }
}
