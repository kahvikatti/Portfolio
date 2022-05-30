using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is attached to both hands of the player character 3D model
public class Grab : MonoBehaviour
{
    private bool hold;
    public KeyCode grabKey; //Set to Mouse0 for left hand, Mouse1 for right hand
    public bool canGrab;
    public bool RightHand; //Set to true for right hand to distinguish between hands when grabbing objects

    void Update()
    {
        if (canGrab)
        {
            if (Input.GetKey(grabKey))
            {
                hold = true;
            }

            //Destroy Fixed Joint when object is released to detach object from player
            else
            {
                hold = false;
                Destroy(GetComponent<FixedJoint>());
            }
        }
    }

    //Create a Fixed Joint for player's hand to hold items
    private void OnCollisionEnter(Collision col)
    {
        if (hold && col.transform.tag == "Item" || hold && col.transform.tag == "Pizza" || hold && col.transform.tag == "Drink" || hold && col.transform.tag == "Bin")
        {
            Rigidbody rb = col.transform.GetComponent<Rigidbody>();
            if (rb != null)
            {
                FixedJoint fj = transform.gameObject.AddComponent(typeof(FixedJoint)) as FixedJoint;
                fj.connectedBody = rb;
            }
            else
            {
                FixedJoint fj = transform.gameObject.AddComponent(typeof(FixedJoint)) as FixedJoint;
            }
        }
    }
}
