using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    Animator m_Animator;
    GameManager gameManager;
    ProjectileScript projectile;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        projectile = GameObject.Find("Projectile").GetComponent<ProjectileScript>();
    }

    private void OnCollisionEnter(Collision other)
    {
        //Take damage if you hit an obstacle. If health reaches 0, player dies.
        if (other.gameObject.tag == "Obstacle")
        {
            gameManager.health--;
            gameManager.UpdateHealth();

            if(gameManager.health <= 0)
            {
                m_Animator.SetTrigger("Die");
                gameManager.GameOver();
            }
        }

        //Gain points for collecting knights
        if (other.gameObject.tag == "Knight")
        {
            m_Animator.SetTrigger("Eat");
            Destroy(other.gameObject);
            gameManager.UpdateScore(+5);
        }


        //Gain health for collecting bottles
        if (other.gameObject.tag == "Bottle")
        {
            m_Animator.SetTrigger("Eat");
            Destroy(other.gameObject);
            if (gameManager.health < 3)
            {
                gameManager.health++;
            }
            gameManager.UpdateHealth();
        }

        //Gain a projectile for collecting a fireball
        if (other.gameObject.tag == "Projectile")
        {
            m_Animator.SetTrigger("Eat");
            Destroy(other.gameObject);
            projectile.projectileCollected = true;
            gameManager.UpdateFireball();
        }
    }

}
