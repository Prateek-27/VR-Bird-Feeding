using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lights : MonoBehaviour
{
    public GameObject LightObject1;
    public GameObject LightObject2;
    public GameObject LightObject3;
    public GameObject LightObject4;
    public GameObject LightObject5;
    public GameObject LightObject6;
    public GameObject day_night;
    private bool LightEnabled = false;
    public bool day;
    // Start is called before the first frame update
    void Start()
    {
        day_night = GameObject.Find("/Day Night Mode");
        LightObject1 = GameObject.Find("/Building/Lights/Spot Light 1");
        LightObject2 = GameObject.Find("/Building/Lights/Spot Light 2");
        LightObject3 = GameObject.Find("/Building/Lights/Spot Light 3");
        LightObject4 = GameObject.Find("/Building/Lights/Spot Light 4");
        LightObject5 = GameObject.Find("/Hot Air Balloon/Lights/topL");
        LightObject6 = GameObject.Find("/Hot Air Balloon/Lights/bottomL");
    }

    // Update is called once per frame
    void Update()
    {
        day = day_night.GetComponent<DayNightModeController>().day;

        if (day)
        {
            LightEnabled = false;
            LightObject1.GetComponent<Light>().enabled = LightEnabled;
            LightObject2.GetComponent<Light>().enabled = LightEnabled;
            LightObject3.GetComponent<Light>().enabled = LightEnabled;
            LightObject4.GetComponent<Light>().enabled = LightEnabled;
            LightObject5.GetComponent<Light>().enabled = LightEnabled;
            LightObject6.GetComponent<Light>().enabled = LightEnabled;
        }
        else
        {
            LightEnabled = true;
            LightObject1.GetComponent<Light>().enabled = LightEnabled;
            LightObject2.GetComponent<Light>().enabled = LightEnabled;
            LightObject3.GetComponent<Light>().enabled = LightEnabled;
            LightObject4.GetComponent<Light>().enabled = LightEnabled;
            LightObject5.GetComponent<Light>().enabled = LightEnabled;
            LightObject6.GetComponent<Light>().enabled = LightEnabled;
        }
    }

}

