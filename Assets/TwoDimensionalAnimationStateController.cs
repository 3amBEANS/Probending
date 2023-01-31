using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDimensionalAnimationStateController : MonoBehaviour
{
    Animator animator;
    float velocityZ = 0.0f;
    float velocityX = 0.0f;
    public float acceleration = 2.0f;
    public float deacceleration = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        //search for the gameobject this script is attached to for the animator component. 
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //input will be true if the player is pressing on the passed in key parameter.
        //get key input from the player.
        bool forwardPressed = Input.GetKey("w");
        bool rightPressed = Input.GetKey("d");
        bool leftPressed = Input.GetKey("a");
        bool runPressed = Input.GetKey("left shift");

        //if player presses forward, increase velocity in z direction
        if (forwardPressed && velocityZ < 0.5f && !runPressed)
        {
            velocityZ += Time.deltaTime * acceleration;
        }
        //increase velocity in the left direction
        if (leftPressed && velocityX > -0.5f && !runPressed)
        {
            velocityX -= Time.deltaTime * acceleration;
        }
        //increase velocity in the right direction
        if (rightPressed && velocityX < 0.5f && !runPressed)
        {
            velocityX += Time.deltaTime * acceleration;
        }

        if(!forwardPressed && velocityZ > 0.0f)
        {
            velocityZ -= Time.deltaTime * deacceleration;
        }

        if (!forwardPressed && velocityZ < 0.0f)
        {
            velocityZ = 0.0f;
        }

        if(!leftPressed && velocityX < 0.0f)
        {
            velocityX += Time.deltaTime * deacceleration;
        }

        if(!rightPressed && velocityX > 0.0f)
        {
            velocityX -= Time.deltaTime * deacceleration;
        }

        if (!leftPressed && !rightPressed && velocityX != 0.0f && (velocityX > -0.05f && velocityX < 0.05f))
        {
            velocityX = 0.0f;   
        }

        animator.SetFloat("Velocity Z", velocityZ);
        animator.SetFloat("Velocity X", velocityX);
    }
}
