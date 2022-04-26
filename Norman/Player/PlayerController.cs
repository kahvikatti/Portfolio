using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float strafeSpeed;

    public Rigidbody hips;

    public int maxStealth = 20;
    public int currentStealth;
    public StealthBar stealthBar;

    void Start()
    {
        hips = GetComponent<Rigidbody>();
        currentStealth = 0;
        stealthBar.SetMaxStealth(20);
        stealthBar.SetStealth(0);
    }

    public void TakeDamage(int damage)
    {
        currentStealth += damage;

        stealthBar.SetStealth(currentStealth);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            hips.AddForce(hips.transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            hips.AddForce(-hips.transform.right * strafeSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            hips.AddForce(-hips.transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            hips.AddForce(hips.transform.right * strafeSpeed);
        }
    }
}
