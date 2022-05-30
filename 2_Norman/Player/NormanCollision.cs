using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormanCollision : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip bonk;

    void Start()
    {
        audioSource = GameObject.Find("SFX").GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.relativeVelocity.magnitude > 8)
        {
            audioSource.PlayOneShot(bonk);
        }
    }
}
