using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Arraysample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5, 6 };
        jaggedArray[2] = new int[] { 7, 8, 9 };

        Debug.Log(jaggedArray[1][0]);

        int[][] jaggedArray2 = // new int[][]
        {
            new int[] { 0, 5, 6 },
            new int[] { 2, 6 },
            new int[] { 7, 1, 6, 3 }
        };

        float[] floats = new float[5];
        Array.Clear(floats, 0, 3);
        Array.Resize(ref floats, floats.Length + 1);
    }
}
