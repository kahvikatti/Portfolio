using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    [SerializeField]
    private Toggle toggleMusic;
    [SerializeField]
    private AudioSource myMusic;
    [SerializeField]
    private Toggle toggleSFX;
    [SerializeField]
    private AudioSource mySFX;

    public void Awake()
    {
        if (!PlayerPrefs.HasKey("music"))
        {
            PlayerPrefs.SetInt("music", 1);
            toggleMusic.isOn = true;
            myMusic.enabled = true;
            PlayerPrefs.Save();
        }

        else
        {
            if (PlayerPrefs.GetInt ("music") == 0)
            {
                myMusic.enabled = false;
                toggleMusic.isOn = false;
            }
            else
            {
                myMusic.enabled = true;
                toggleMusic.isOn = true;
            }
        }

        if (!PlayerPrefs.HasKey("sfx"))
        {
            PlayerPrefs.SetInt("sfx", 1);
            toggleSFX.isOn = true;
            mySFX.enabled = true;
            PlayerPrefs.Save();
        }

        else
        {
            if (PlayerPrefs.GetInt("sfx") == 0)
            {
                mySFX.enabled = false;
                toggleSFX.isOn = false;
            }
            else
            {
                mySFX.enabled = true;
                toggleSFX.isOn = true;
            }
        }
    }

    public void ToggleMusic()
    {
        if (toggleMusic.isOn)
        {
            PlayerPrefs.SetInt("music", 1);
            myMusic.enabled = true;
        }
        else
        {
            PlayerPrefs.SetInt("music", 0);
            myMusic.enabled = false;
        }
        PlayerPrefs.Save();
    }

    public void ToggleSFX()
    {
        if (toggleSFX.isOn)
        {
            PlayerPrefs.SetInt("sfx", 1);
            mySFX.enabled = true;
        }
        else
        {
            PlayerPrefs.SetInt("sfx", 0);
            mySFX.enabled = false;
        }
        PlayerPrefs.Save();
    }
}
