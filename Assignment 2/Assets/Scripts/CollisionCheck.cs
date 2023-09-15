using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public bool collisionBuilding = false;
    public bool inZone1 = false;
    public bool onZone1base = false;

    void OnTriggerEnter(Collider collision)
    {
        // Building Collision
        if (collision.gameObject.name == "Building (1)")
        {
            collisionBuilding = true;
        }

        // Zone 1 Bubble Collision
        if (collision.gameObject.name == "zone1Bubble")
        {
            inZone1 = true;
        }

        // Zone 1 Base Collision
        if (collision.gameObject.name == "zone1Base")
        {
            onZone1base = true;
        }


        Debug.Log("Collision detected with " + collision.gameObject.name);
    }

    void OnTriggerExit(Collider collision)
    {
        // Building Exit
        if (collision.gameObject.name == "Building (1)")
        {
            collisionBuilding = false;
        }

        // Zone 1 Bubble exit
        if (collision.gameObject.name == "zone1Bubble")
        {
            inZone1 = false;
        }

        // Zone 1 Base exit
        if (collision.gameObject.name == "zone1Base")
        {
            onZone1base = false;
        }


        Debug.Log("Collision ended with " + collision.gameObject.name);
    }
}
