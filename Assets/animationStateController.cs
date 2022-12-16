using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{

    Animator animator;
    float velocity = 0.0f;
    public float acceleration = 0.1f;
    public float decceleration = 0.1f;
    int velocityHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //increases performance
        velocityHash = Animator.StringToHash("Velocity");
    }

    // Update is called once per frame
    void Update()
    {

        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        //player presses w key
        if (forwardPressed && velocity < 5.0f)
        {
            velocity += Time.deltaTime * acceleration;
        }
        if (!forwardPressed && velocity > 0.0f)
        {
            velocity -= Time.deltaTime * decceleration;
        }
        if(!forwardPressed && velocity < 0.0f)
        {
            velocity = 0.0f;
        }


        animator.SetFloat(velocityHash, velocity);

    }
}
