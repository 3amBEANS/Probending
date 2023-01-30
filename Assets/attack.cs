using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class attack : MonoBehaviour
{
    
    //straight bullet
    public GameObject sBullet;
    public GameObject cBullet;
    public Transform firepoint;
    public float recXPos;
    public float recYPos;
    public float recZPos;
    public Transform camPos;
    public int bulletSpeed = 27;

    //curved bullet
    public Transform playerCam;
    private float xRotation;
    private float yRotation;



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
            xRotation = playerCam.rotation.x;
            yRotation = playerCam.rotation.y;
            recXPos = firepoint.position.x;
            recYPos = firepoint.position.y;
            recZPos = firepoint.position.z;


        }
        else if (Input.GetButtonUp("Fire2"))
        {
            xRotation = playerCam.rotation.x - xRotation;
            yRotation = playerCam.rotation.y - yRotation;
            Debug.Log(xRotation + " + " + yRotation);
            GameObject bullet = Instantiate(cBullet);

            //bullet.setXRot(xRotation);
            //bullet.setYRot(yRotation);

            bullet.transform.position = new Vector3((recXPos+firepoint.position.x)/2, (recYPos + firepoint.position.y) / 2, (recZPos + firepoint.position.z) / 2);

            Vector3 rotation = bullet.transform.rotation.eulerAngles;

            bullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

            bullet.GetComponent<Rigidbody>().AddForce(firepoint.forward * bulletSpeed, ForceMode.Impulse);

        }
    }
    

}
