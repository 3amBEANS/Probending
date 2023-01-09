using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    Rigidbody rb;
    public GameObject firePoint;
    public int throwForce;
    int penis = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(firePoint.transform.forward * throwForce);
        Destroy(gameObject, penis);
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


}
