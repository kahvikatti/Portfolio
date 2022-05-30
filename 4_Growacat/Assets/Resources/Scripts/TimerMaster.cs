using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimerMaster : MonoBehaviour
{

    DateTime currentDate;

    [SerializeField] string saveLocation;
    public static TimerMaster instance;

    private void Awake()
    {
        instance = this;
        saveLocation = "lastSavedDate1";
    }

    public float CheckDate()
    {
        currentDate = System.DateTime.Now;
        string tempString = PlayerPrefs.GetString(saveLocation, "1");
        long tempLong = Convert.ToInt64(tempString);
        DateTime oldDate = DateTime.FromBinary(tempLong);
        print("oldDate : " + oldDate);

        TimeSpan difference = currentDate.Subtract(oldDate);
        print("Difference: " + difference);

        return (float)difference.TotalSeconds;
    }

    public void SaveDate()
    {
        PlayerPrefs.SetString(saveLocation, System.DateTime.Now.ToBinary().ToString());
        print("Saving " + System.DateTime.Now);
    }
}
