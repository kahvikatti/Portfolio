using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVScript : MonoBehaviour
{
    public GameObject tv;
    public bool chadUpset = false;

    //If player moves TV too far from its place, NPC gets upset and player takes damage (executed in the Subtitles script)
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject == tv)
        {
            chadUpset = true;
            Destroy(this);
        }
    }
}
