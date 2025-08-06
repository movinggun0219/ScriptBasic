using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumExample : MonoBehaviour
{
     [Flags] 
    enum Day
    { 
        Sunday = 0, 
        Monday = 1, 
        Tuesday = 2, 
        Wednesday = 4, 
        Thursday = 8, 
        Friday = 16, 
        Saturday = 32 
    } 
        
    enum Month : byte
    {
        jan = 1, Feb,
        Mar, Apr,May, Jun, Jul,
        Aug, Sep,Oct, Nov, Dec
    };

    void Start()
    {
        Day today = Day.Wednesday;
        int dayNumber = (int)today;
        //Debug.LogFormat("{0} is day number {1}.", today, dayNumber);
        Debug.Log($"{today} is day number {dayNumber}.");


        Month thisMonth = Month.Dec;
        byte monthNumber = (byte)thisMonth;
        //Debug.LogFormat("{0} is month number #{1}.", thisMonth, monthNumber);
        Debug.Log($"{thisMonth} is month number #{monthNumber}.");

        Day workingDay = Day.Monday | Day.Tuesday | Day.Wednesday | Day.Thursday | Day.Thursday | Day.Friday;
        Debug.LogFormat($"working days are {workingDay}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
