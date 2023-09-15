using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCounter : MonoBehaviour
{
    public float appleCount;
    public float appleFed;

    public float strawberryCount;
    public float strawberryFed;

    public float pearCount;
    public float pearFed;

    public float peachCount;
    public float peachFed;

    public float peanutCount;
    public float peanutFed;

    // Start is called before the first frame update
    void Start()
    {
        appleCount = 0f;
        appleFed = 0f;
        strawberryCount = 0f;
        strawberryFed = 0f;
        pearCount = 0f;
        pearFed = 0f;
        peachCount = 0f;
        peachFed = 0f;
        peanutCount = 0f;
        peanutFed = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(appleCount);
    }
}
