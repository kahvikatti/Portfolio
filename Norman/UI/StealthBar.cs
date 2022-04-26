using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxStealth(int stealth)
    {
        slider.maxValue = stealth;
        slider.value = stealth;
    }

    public void SetStealth(int stealth)
    {
        slider.value = stealth;
    }
}
