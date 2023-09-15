using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdCollision4 : MonoBehaviour
{
    public bool bird4 = false;
    public bool bird44 = false;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "bird4")
        {
            bird4 = true;
        }
        if (collision.gameObject.name == "bird4 (1)")
        {
            bird44 = true;
        }
        //Debug.Log(collision.gameObject.name);
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "bird4")
        {
            bird4 = false;
        }
        if (collision.gameObject.name == "bird4 (1)")
        {
            bird44 = false;
        }
        //Debug.Log(collision.gameObject.name);
    }
}
