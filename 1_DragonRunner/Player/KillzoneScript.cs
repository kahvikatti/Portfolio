using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillzoneScript : MonoBehaviour
{

    //Destroys knights when they hit player's hitbox.
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Knight")
        {
            Destroy(other.gameObject);
        }
    }
}
