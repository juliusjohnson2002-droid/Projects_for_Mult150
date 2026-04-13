using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onGUI()
    {
        if(GUI.Button(new Rect(Screen.width/2 - 50 , Screen.height / 2 - 50, 100,100), "click"))
        {
            GetComponent<Camera>().backgroundColor = 
                new Color (Random.Range(0f,1f),Random.Range(0f,1f), Random.Range (0f, 1f));
        }
    }
}
