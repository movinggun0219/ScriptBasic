using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableType : MonoBehaviour
{
    static public bool staticVariable = true; // 정적 변수
    int globalVariable = 1; // 전역변수

    
    public int publicValue = 5;
    public int pv2 = 4;
    public bool IsPublic;
    void Start()
    {
        int localVariable = 1;
        int localVariable2;

        //Debug.Log(localVariable2);
        Localvariable(1);
        Debug.Log(pv2);
    }

    // Update is called once per frame
    void Localvariable(int parameter)
    {
        float localVariable = parameter;
    }
}
