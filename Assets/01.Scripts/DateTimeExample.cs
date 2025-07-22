using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTimeExample : MonoBehaviour
{

    void Start()
    {
        Debug.Log(default(DateTime));
        Debug.Log(DateTime.Now);
        Debug.Log(DateTime.Now.Year);
        Debug.Log(DateTime.Now.Second);

        DateTime dt = new DateTime(2025, 07, 22, 15, 32, 00);
        Debug.Log(dt.Year);

        DateTime today = DateTime.Today;
        Debug.Log(today);

        DateTime tommorrow = today.AddDays(1);
        DateTime yesterday = today.AddDays(-1);

        TimeSpan timeSpan = int Timespan.Days { get; }
    }
}
