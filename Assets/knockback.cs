using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{

    
    [SerializeField] private float knockbackStrength;
    private Rigidbody m_rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 direction = collision.transform.position - transform.position;
            direction.y = 0;
            m_rigidbody.AddForce(-direction.normalized * knockbackStrength, ForceMode.Impulse);
        }
    }
}
