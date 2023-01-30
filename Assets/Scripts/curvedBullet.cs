using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curvedBullet : MonoBehaviour
{

    float xRot;
    float yRot;
    
    Rigidbody rb;
    float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        //rb.AddForce(new Vector3(xRot*speed, 0, 0));
        rb.AddForce(new Vector3(50, 0, 0));
    }

    public void setXRot(float xRotation)
    {
        xRot = xRotation;
    }

    public void setYRot(float yRotation)
    {
        yRot = yRotation;
    }

}
