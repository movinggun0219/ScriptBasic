using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoo : MonoBehaviour
{
    int cupsIntheSink = 4;
    void Start()
    {
        while (cupsIntheSink > 0)
        {
            Debug.Log("washed cup");
            cupsIntheSink--;
        }

        bool shouldContinue = false;
        do
        {
            print("Hello world");
        } while (shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
