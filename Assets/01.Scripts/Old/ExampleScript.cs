using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    Color mycolor;
    Renderer myrender;
    void Start()
    {
        mycolor = GetComponent<Renderer>().material.color;
        myrender = GetComponent<Renderer>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            mycolor = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            mycolor = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            mycolor = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            mycolor = Color.black;
        }

        myrender.material.color = mycolor;

    }
}
