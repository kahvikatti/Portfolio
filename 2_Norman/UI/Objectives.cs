using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objectives : MonoBehaviour
{
    public PlayerController playerController;

    public GameObject gameOverPanel;
    public GameObject successPanel;
    public bool gameOver = false;

    void Update()
    {
       if (playerController.currentStealth >= 20)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOver = true;
    }

    public void Success()
    {
        successPanel.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
