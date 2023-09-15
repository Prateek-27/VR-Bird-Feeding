using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public bool collisionBuilding = false;
    public bool inZone1 = false;
    public bool onZone1base = false;
    public bool inZone2 = false;
    public bool onZone2base = false;
    public bool inZone3 = false;
    public bool onZone3base = false;
    public bool inZone4 = false;
    public bool onZone4base = false;
    public bool inZone5 = false;
    public bool onZone5base = false;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Building (1)")
        {
            collisionBuilding = true;
        }
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
        //Debug.Log("Collision detected with " + collision.gameObject.name);

        // Zone 2 Bubble Collision
        if (collision.gameObject.name == "zone2Bubble")
        {
            inZone2 = true;
        }

        // Zone 2 Base Collision
        if (collision.gameObject.name == "zone2Base")
        {
            onZone2base = true;
        }

        // Zone 3 Bubble Collision
        if (collision.gameObject.name == "zone3Bubble")
        {
            inZone3 = true;
        }

        // Zone 3 Base Collision
        if (collision.gameObject.name == "zone3Base")
        {
            onZone3base = true;
        }
        // Zone 4 Bubble Collision
        if (collision.gameObject.name == "zone4Bubble")
        {
            inZone4 = true;
        }

        // Zone 4 Base Collision
        if (collision.gameObject.name == "zone4Base")
        {
            onZone4base = true;
        }
        // Zone 5 Bubble Collision
        if (collision.gameObject.name == "zone5Bubble")
        {
            inZone5 = true;
        }

        // Zone 5 Base Collision
        if (collision.gameObject.name == "zone5Base")
        {
            onZone5base = true;
        }
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
        // Zone 2 Bubble exit
        if (collision.gameObject.name == "zone2Bubble")
        {
            inZone2 = false;
        }

        // Zone 2 Base exit
        if (collision.gameObject.name == "zone2Base")
        {
            onZone2base = false;
        }

        // Zone 3 Bubble exit
        if (collision.gameObject.name == "zone3Bubble")
        {
            inZone3 = false;
        }

        // Zone 3 Base exit
        if (collision.gameObject.name == "zone3Base")
        {
            onZone3base = false;
        }
        // Zone 4 Bubble exit
        if (collision.gameObject.name == "zone4Bubble")
        {
            inZone4 = false;
        }

        // Zone 4 Base exit
        if (collision.gameObject.name == "zone4Base")
        {
            onZone4base = false;
        }
        // Zone 5 Bubble exit
        if (collision.gameObject.name == "zone5Bubble")
        {
            inZone5 = false;
        }

        // Zone 5 Base exit
        if (collision.gameObject.name == "zone5Base")
        {
            onZone5base = false;
        }

        //Debug.Log("Collision ended with " + collision.gameObject.name);
    }
    }
