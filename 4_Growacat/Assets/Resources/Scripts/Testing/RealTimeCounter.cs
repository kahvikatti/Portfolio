using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealTimeCounter : MonoBehaviour
{

    public float timer;

    void Start()
    {
        timer = 300;

        timer -= TimerMaster.instance.CheckDate();
    }

    void Update()
    {
        timer -= Time.deltaTime;
    }

    private void OnGUI()
    {
        if(GUI.Button (new Rect(10, 10, 100, 50), "Save Time"))
        {
            ResetClock();
        }
        if(GUI.Button(new Rect(10, 150, 100, 50), "Check Time"))
        {
            print(60 - TimerMaster.instance.CheckDate() + " has passed");
        }

        GUI.Label(new Rect(10, 150, 100, 50), timer.ToString());
    }

    void ResetClock()
    {
        TimerMaster.instance.SaveDate();
        timer = 300;
        timer -= TimerMaster.instance.CheckDate();
    }
}
