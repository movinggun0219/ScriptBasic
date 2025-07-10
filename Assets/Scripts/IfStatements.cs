using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        coffeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // 커피 온도가  가장 뜨거운 섭취 온도보다 높은경우
        if (coffeTemperature > hotLimitTemperature)
        {
            print("커피가 너무 뜨겁다");
        }

        // 커피 온도가  가장 차가운 섭취 온도보다 낮은 경우
        else if (coffeTemperature < coldLimitTemperature)
        {
            print("커피가 너무 차갑다");
        }

        // 둘다 아닌 경우 
        else
        {
            print("커피 온도가 적당하다");
        }
    }
}
