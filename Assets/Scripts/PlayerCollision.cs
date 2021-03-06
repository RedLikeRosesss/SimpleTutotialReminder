using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement playerMovementScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacles") 
        {
            playerMovementScript.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
