using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip slurp;

    void Start()
    {
        audioSource = GameObject.Find("bin").GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Pizza")
        {
            Destroy(target.gameObject);
            Score.pizzaScoreValue += 1;
            audioSource.PlayOneShot(slurp);

        }
        if (target.tag == "Drink")
        {
            Destroy(target.gameObject);
            Score.drinkScoreValue += 1;
            audioSource.PlayOneShot(slurp);
        }
    }
}
