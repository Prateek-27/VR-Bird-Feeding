using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightModeController : MonoBehaviour
{
    public GameObject lightSource;
    public bool day = true;
    public Vector3 rota;
    public float day_night_clock = 200f;
    public float timer = 0f;
    public float sec;
    private void Start()
    {
        lightSource = GameObject.Find("/Directional Light");
        //sec = (360f/day_night_clock) / 60f;
        //sec = 360f / day_night_clock;
        sec = 360f / day_night_clock;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= day_night_clock/2)
        {
            day = false;
        }
        Vector3 rota = new Vector3(Time.deltaTime * sec, 0, 0);
        lightSource.transform.Rotate(rota);
        if (timer >= day_night_clock)
        {
            day = true;
            timer = 0f;

        }

    }
}

