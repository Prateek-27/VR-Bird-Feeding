using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdCollision1 : MonoBehaviour
{
    public bool bird1 = false;
    public bool bird11 = false;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "bird1")
        {
            bird1 = true;
        }
        if (collision.gameObject.name == "bird1 (1)")
        {
            bird11 = true;
        }
        //Debug.Log(collision.gameObject.name);
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "bird1")
        {
            bird1 = false;
        }
        if (collision.gameObject.name == "bird1 (1)")
        {
            bird11 = false;
        }
        //Debug.Log(collision.gameObject.name);
    }
}
