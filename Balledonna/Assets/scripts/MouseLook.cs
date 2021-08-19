using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{public float mouseSensitivity=100f;
public Transform gun;
float xRotation=0f;
float yRotation=0f;
    /*void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
    }*/

    // Update is called once per frame
    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;
        float mouseY=Input.GetAxis("Mouse Y")*mouseSensitivity*Time.deltaTime;
        xRotation-=mouseY;
        xRotation=Mathf.Clamp(xRotation,-22.5f,22.5f);
        yRotation-=mouseX;
        yRotation=Mathf.Clamp(yRotation,-22.5f,22.5f);
        transform.localRotation=Quaternion.Euler(xRotation,-yRotation,0f);
      
    }
}
