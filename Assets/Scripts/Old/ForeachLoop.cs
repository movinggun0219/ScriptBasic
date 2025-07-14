using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var strings = new string[3];
        strings[0] = "First string";
        strings[1] = "second string";
        strings[2] = "Third string";

        foreach (string item in strings)
        {
            print(item);
        }

        for (int i = 0; i < strings.Length; i++)
        {
            print(strings[i]);
        }


        var myList = new List<int>();
        foreach (var item in myList)
        {
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
