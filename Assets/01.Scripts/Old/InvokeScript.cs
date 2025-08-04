using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    public GameObject target;
    int sum ;

    void Start()
    {
        sum = 0;
        //Invoke("SpawnObject", 2.0f);
        InvokeRepeating("SpawnObject", 2.0f, 1.0f);
        
    }

    void Update()
    {
        if (sum >= 10)
        {
            CancelInvoke("SpawnObject");
        }
    }
    void SpawnObject()
    {
        // int와 float의 max값이 불포함 , 포함인지 잘확인 
        int i = Random.Range(-5, 5);
        float y = Random.Range(-5, 5);


        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);

        Instantiate(
            target,
            new Vector3(x, 2, z),
            Quaternion.identity
        );
        sum++;
    }
}
