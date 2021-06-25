using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody playerRB;

    public float forwardForce = 2000f;
    public float sidewayFroce = 500f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d")) 
        {
            playerRB.AddForce(sidewayFroce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            playerRB.AddForce(-sidewayFroce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        playerRB.AddForce(0, 0, forwardForce * Time.deltaTime); // Time.deltaTime calculates a time since last frame
    }
}
