using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdCollision3 : MonoBehaviour
{
    public bool bird3 = false;
    public bool bird33 = false;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "bird3")
        {
            bird3 = true;
        }
        if (collision.gameObject.name == "bird3 (1)")
        {
            bird33 = true;
        }
        //Debug.Log(collision.gameObject.name);
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "bird2")
        {
            bird3 = false;
        }
        if (collision.gameObject.name == "bird2 (1)")
        {
            bird33 = false;
        }
        //Debug.Log(collision.gameObject.name);
    }
}
