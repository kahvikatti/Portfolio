using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chad : MonoBehaviour
{
    public bool inLineOfSight = false;

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            inLineOfSight = true;
        }
    }

    private void OnTriggerExit(Collider target)
    {
        if (target.tag == "Player")
        {
            inLineOfSight = false;
        }
    }
}
