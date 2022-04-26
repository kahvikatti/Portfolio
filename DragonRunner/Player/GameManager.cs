using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public int score;
    float gameTime = 0.0f;
    public int health;
    public GameObject gameOverPanel;
    public bool isGameActive;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public ProjectileScript projectileScript;
    public GameObject panelFireball;
    public GameObject panelHelp;

    void Start()
    {
        health = 3;
        score = 0;
        UpdateScore(0);
        isGameActive = true;
        projectileScript = GameObject.Find("Projectile").GetComponent<ProjectileScript>();
    }

    void Update()
    {
        if (isGameActive)
        {
            gameTime += Time.deltaTime;
            if(gameTime >= 1)
            {
                score += (int)gameTime;
                gameTime -= (int)gameTime;
            }
        }
        scoreText.text = "Score: " + score;
    }

    public void UpdateHealth()
    {
        if (health == 3)
        {
            heart1.gameObject.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
        }
        if (health == 2)
        {
            heart1.gameObject.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(false);
        }
        if (health == 1)
        {
            heart1.gameObject.SetActive(true);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }
        if (health <= 0)
        {
            heart1.gameObject.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void UpdateFireball()
    {
        if (projectileScript.projectileCollected == true)
        {
            panelFireball.SetActive(true);
        }
        if (projectileScript.projectileCollected == false)
        {
            panelFireball.SetActive(false);
        }
    }

    public void GameOver()
    {
        gameOverPanel.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void Help()
    {
        panelHelp.SetActive(true);
        isGameActive = false;
    }

    public void CloseHelp()
    {
        panelHelp.SetActive(false);
        isGameActive = true;
    }
}
