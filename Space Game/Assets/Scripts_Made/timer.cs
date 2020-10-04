using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public string LevelToLoad;
    private float t = 20;
    private TextAsset timerSeconds;
    
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        t -= Time.deltaTime;
        if (t <= 0)
        {
            Application.LoadLevel(LevelToLoad);
        }
        
   
        
    }
}
