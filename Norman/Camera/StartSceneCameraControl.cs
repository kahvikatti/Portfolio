using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script is used only in the first menu scene
public class StartSceneCameraControl : MonoBehaviour
{
    public float rotationSpeed = 1;
    public Transform root;

    float mouseX, mouseY;

    public float spineOffset;

    public ConfigurableJoint hipJoint, spineJoint;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void FixedUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        Quaternion rootRotation = Quaternion.Euler(mouseY, mouseX, 0);

        root.rotation = rootRotation;

        hipJoint.targetRotation = Quaternion.Euler(0, -mouseX, 0);
        spineJoint.targetRotation = Quaternion.Euler(-mouseY + spineOffset, 0, 0);
    }
}