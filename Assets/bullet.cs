using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    Rigidbody rb;
    public GameObject firePoint;
    public int throwForce;

    private IEnumerator coroutine;
    
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //rb.AddForce(firePoint.transform.forward * throwForce);

        //make objects disappear
        coroutine = BulletDisappear(2.0f);
        StartCoroutine(coroutine);

    }

    private IEnumerator BulletDisappear(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

    
}
