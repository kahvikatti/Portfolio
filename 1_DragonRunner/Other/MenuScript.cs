using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Runner()
    {
        SceneManager.LoadScene("RunnerScene");
    }

    public void Close()
    {
        Application.Quit();
    }
}
