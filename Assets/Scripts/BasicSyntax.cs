using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{transform.position.x}위치값");

        if (transform.position.y >= 5f)
        {
            Debug.Log("I'm....");
        }

        if (transform.rotation.x < 4f)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
