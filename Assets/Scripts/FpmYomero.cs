using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpmYomero : MonoBehaviour
{
    public float mouseSensitivity = 50f;
    
    public Transform playerbody;

    float xRotation = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
       //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY; // with + rotation inverts
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * mouseX);
    }
}
