using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;

    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Enemy: " + i);
        }

        var iarray = new int[10];
        for (int i = 0; i < iarray.Length; i++)
        {
            iarray[i] = i;
        }

        for (int i = 9; i >= 0; i--)
        {
            Debug.Log(iarray[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
