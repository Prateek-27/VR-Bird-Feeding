using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdCollision5 : MonoBehaviour
{
    public bool bird5 = false;
    public bool bird55 = false;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "bird5")
        {
            bird5 = true;
        }
        if (collision.gameObject.name == "bird5 (1)")
        {
            bird55 = true;
        }
        Debug.Log(collision.gameObject.name);
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "bird5")
        {
            bird5 = false;
        }
        if (collision.gameObject.name == "bird5 (1)")
        {
            bird55 = false;
        }
        Debug.Log(collision.gameObject.name);
    }
}
