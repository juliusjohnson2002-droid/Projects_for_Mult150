using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
      float speed  =.5f; 
    void Update()
    {
     float offset = Time.time * speed;
     GetComponent<Renderer>().material.mainTextureOffset = new UnityEngine.Vector2 (0, -offset);
    }

    public void SlowDown()
    {
        speed = speed /2; 
    }
    public void SpeedUp()
    {
        speed = speed * 2;
    }
}
