using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Chad chad;
    public PlayerController playerController;

    AudioSource audioSource;
    public AudioClip drinkDrop;
    public AudioClip pizzaDrop;
    public AudioClip plasticDrop;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //If object hits a surface with high enough velocity, play sound effect
    void OnCollisionEnter (Collision col)
    {
        if (col.collider.tag == "Surface" && col.relativeVelocity.magnitude > 3)
        {
            if (tag == "Drink")
            {
                audioSource.PlayOneShot(drinkDrop);
            }
            if (tag == "Pizza")
            {
                audioSource.PlayOneShot(pizzaDrop);
            }
            if (tag == "Bin")
            {
                audioSource.PlayOneShot(plasticDrop);
            }
        }

        //If velocity is too high, and player is in NPC's line of sight, player takes damage
        if (chad.inLineOfSight == true)
        {
            if (col.collider.tag == "Surface" && col.relativeVelocity.magnitude > 12)
            {
                playerController.TakeDamage(1);
            }
        }
    }
}
