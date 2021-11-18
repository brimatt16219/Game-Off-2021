using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RoomSwitch : MonoBehaviour
{
    public Transform player;
    public Transform a;
    public Transform b;

    public bool isA = false;
    bool playerInRange = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerInRange && isA)
            {
                player.position = b.position;
            }
            else if (playerInRange)
            {
                player.position = a.position;
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
