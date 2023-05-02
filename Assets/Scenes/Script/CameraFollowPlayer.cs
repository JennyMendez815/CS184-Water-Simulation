using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform orientation;

    private float xRotation = 0;
    private float yRotation = 0;


    void Update() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        float x = Input.GetAxisRaw("Mouse X") * Time.deltaTime * 400;
        float y = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * 400;

        xRotation += x;
        yRotation += y;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(-yRotation, xRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
