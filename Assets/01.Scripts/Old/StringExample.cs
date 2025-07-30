using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StringExample : MonoBehaviour
{
    void Start()
    {
        string name = "Coder Zero";
        char[] charArrays = name.ToCharArray(); // name문자열이 charArrays 문자 배열로 변환함. 
        //Debug.Log(charArrays[1]); // 출력 : o 

        char[] cArray = { 'A', 'B', 'c', ' ' };
        string s = new string(cArray);
        //Debug.Log(s); // 출력 : ABc          

        var sb = new StringBuilder();
        sb.Append(name);
        sb.Clear();
        sb.Append("Coder One");
        sb.Append("two");


        sb.Insert(6, "C");
        Debug.Log(sb.ToString());
        sb.Remove(6, 3);
        Debug.Log(sb.ToString());
        sb.Replace('C', 'I');
        Debug.Log(sb.ToString());
        sb.Replace('o', 'O', 0, 10);
        Debug.Log(sb.ToString());
    }

    
    void Update()
    {
        
    }
}
