using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{

    public GameObject sBullet;

    public GameObject firepoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Instantiate(sBullet, firepoint.transform.position, firepoint.transform.rotation);

        }
    }


}
