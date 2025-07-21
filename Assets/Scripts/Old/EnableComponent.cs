using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponent : MonoBehaviour
{
    Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
        myLight.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
