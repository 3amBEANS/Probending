using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    
    public GameObject sBullet;
    public Transform firepoint;
    public Transform camPos;
    public int bulletSpeed = 27;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(sBullet);

            //Physics.IgnoreCollision(bullet.GetComponent<Collider>(), firepoint.parent.GetComponent<Collider>());

            bullet.transform.position = firepoint.position;

            Vector3 rotation = bullet.transform.rotation.eulerAngles;

            bullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

            bullet.GetComponent<Rigidbody>().AddForce(firepoint.forward * bulletSpeed, ForceMode.Impulse);
        }
        else if (Input.GetButtonDown("Fire2"))
        {

        }
    }
    

}
