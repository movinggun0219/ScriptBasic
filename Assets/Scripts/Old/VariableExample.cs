using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    void Start()
    {
        int number1;
        number1 = 1;

        int number2 = 2;

        float number3 = 3.4f, number4 = 4.4f;

        bool isBool = true;

        

        Debug.Log(number1);
        Debug.Log(number1.ToString());
        Debug.Log(number3);
        Debug.Log(number3.ToString());
    }


  
}
