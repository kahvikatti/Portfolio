using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * 50f * Time.deltaTime);
    }
}
