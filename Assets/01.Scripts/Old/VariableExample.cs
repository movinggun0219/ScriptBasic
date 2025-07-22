using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    void Start()
    {
        // 16진수
        var hexLiteral = 0xaf;
        // 2진수
        var binaryLiter = 0b_0000_0001;

        // 최대값, 최소값
        int Max = int.MaxValue;
        float f = float.MinValue;

        bool b = default(bool); // b= false

        string s1 = null;
        string s2 = "";
        string s3 = string.Empty;

        if (s1 == s2)
        {
            Debug.Log("same");
        }
        else
        {
            Debug.Log("diff");
        }

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
