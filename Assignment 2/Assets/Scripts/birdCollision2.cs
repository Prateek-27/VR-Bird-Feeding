using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdCollision2 : MonoBehaviour
{
    public bool bird2 = false;
    public bool bird22 = false;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "bird2")
        {
            bird2 = true;
        }
        if (collision.gameObject.name == "bird2 (1)")
        {
            bird22 = true;
        }
        //Debug.Log(collision.gameObject.name);
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "bird2")
        {
            bird2 = false;
        }
        if (collision.gameObject.name == "bird2 (1)")
        {
            bird22 = false;
        }
        //Debug.Log(collision.gameObject.name);
    }
}
