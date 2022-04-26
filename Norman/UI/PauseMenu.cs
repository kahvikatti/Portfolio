using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public static bool InSettings = false;

    public GameObject pauseMenuUI;
    public GameObject settings;

    public AudioSource audioSource;
    public AudioClip error;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused && !InSettings)
            {
                Resume();
                Cursor.lockState = CursorLockMode.Locked;
            }
            if (GamePaused && InSettings)
                audioSource.PlayOneShot(error);
            else
            {
                Pause();
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
        Cursor.visible = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GamePaused = true;
    }

    public void LoadSettings()
    {
        settings.SetActive(true);
        InSettings = true;
    }

    public void CloseSettings()
    {
        settings.SetActive(false);
        InSettings = false;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void RestartLevel()
    {
        Debug.Log("Restart");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }

    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }
}
