using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float mouseSensitivity;
    [SerializeField] float Angle;
    float rotY;
    float rotX;
    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;

    }

   
    void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;
        rotX = Mathf.Clamp(rotX, -Angle, Angle);//Buradan donus acýsýný kýsýtlandýrabiliriz.
        rotY= Mathf.Clamp(rotX, -Angle, Angle);
        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0f);
        transform.rotation = localRotation;
    }
}
