using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour
{
    public int alpha = 5;
    public int beta = 0;
    private int gamma = 5;

    private Anotherclass myOtherClass;
    void Start()
    {
        alpha = 29;
        myOtherClass = new Anotherclass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
        
    }

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpa is  set to: " + alpha);
    }
}
