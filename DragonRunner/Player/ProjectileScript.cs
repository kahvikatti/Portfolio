using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    GameManager gameManager;
    public GameObject projectile;
    PlayerController playerController;
    public bool projectileCollected;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerController = GameObject.Find("Dragon").GetComponent<PlayerController>();
        projectileCollected = false;
    }

    void Update()
    {
        if ((Input.GetButtonDown("Fire1") && playerController.canJump && gameManager.isGameActive))
        {
            FireFireball();
        }
    }

    public void FireFireball()
    {
        if (projectileCollected && gameManager.isGameActive && playerController.canJump)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            projectileCollected = false;
            gameManager.UpdateFireball();
        }
    }
}
