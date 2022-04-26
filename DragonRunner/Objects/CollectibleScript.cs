using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public float speed = 20;
    public float limitX = -60;
    public float newPosX = 230;
    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    //Move collectibles along the play area. Move back to starting position when they reach the edge of the play area
    void Update()
    {
        if (gameManager.isGameActive)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.x <= limitX)
        {
            transform.position = new Vector3(newPosX, transform.position.y, transform.position.z);
        }
    }

 }
