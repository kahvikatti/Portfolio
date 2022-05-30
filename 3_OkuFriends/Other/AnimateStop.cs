using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateStop : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetTrigger("SpinStop");
            Invoke("AnimationReset", 0.1f);
        }
    }

    void AnimationReset()
    {
        anim.ResetTrigger("SpinStop");
    }
}