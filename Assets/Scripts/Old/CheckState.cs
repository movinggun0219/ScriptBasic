using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject myObject; 
    void Start()
    {
        var hexLiteral = 0xaf;
        var binaryLiter = 0b_0000_0001;
        Debug.Log("활성 자기 자신: " + myObject.activeSelf);
        Debug.Log("계층 구조에서 활성화됨" + myObject.activeInHierarchy);
    }

}
