using UnityEngine;
using System.Collections;

public class Anotherclass
{
    public int apples;
    public int abananas;

    private int stapler;
    private int sellotape;

    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total:" + answer);
    }

    private void officesort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total" + answer); 
    }
}