using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoomSwitch : MonoBehaviour
{
    public Transform player;
    public Transform a;
    public Transform b;

    bool AtA = false;
    bool playerInRange = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerInRange && AtA)
            {
                player.position = b.position;
                AtA = false;
            }
            else if (playerInRange)
            {
                player.position = a.position;
                AtA = true;
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

}
