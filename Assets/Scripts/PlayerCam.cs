using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
   
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;


    //rotating character model as well
    public Transform modelRotation;
    public Transform firePointRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //get mouse rotaiton
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //rotation cam and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        modelRotation.rotation = Quaternion.Euler(0, yRotation , 0);
        firePointRotation.rotation = Quaternion.Euler(xRotation, yRotation, 0);

        

    }
}
