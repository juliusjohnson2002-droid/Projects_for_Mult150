using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public GameControlScrript control;
    // Update is called once per frame
    void Update()
    {
      transform.Translate (0,0,control.ObjectSpeed);
    }
}
