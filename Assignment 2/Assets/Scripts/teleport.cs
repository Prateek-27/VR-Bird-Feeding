using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject side1;
    public GameObject side2;
    public GameObject side3;
    public GameObject side4;
    public GameObject marker;

    public GameObject cam;
    public GameObject telecam;
    public GameObject bottom;
    public GameObject player;
    public bool tele;

    // Start is called before the first frame update
    void Start()
    {
        side1 = GameObject.Find("/Hot Air Balloon/Basket/side1");
        side2 = GameObject.Find("/Hot Air Balloon/Basket/side2");
        side3 = GameObject.Find("/Hot Air Balloon/Basket/side3");
        side4 = GameObject.Find("/Hot Air Balloon/Basket/side4");
        marker = GameObject.Find("/Marker");
        cam = GameObject.Find("/MainPlayer/Main Camera");
        telecam = GameObject.Find("/TeleCamera");
        bottom = GameObject.Find("/Hot Air Balloon/Basket/bottom");
        player = GameObject.Find("/MainPlayer");
        marker.GetComponent<MeshRenderer>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        tele = (side1.GetComponent<teleport_to_basket>().teletrigger) || (side2.GetComponent<teleport_to_basket>().teletrigger) || (side3.GetComponent<teleport_to_basket>().teletrigger) ||
            (side4.GetComponent<teleport_to_basket>().teletrigger);
        //Debug.Log(tele);

        if(tele == true)
        {
            // Activate marker and switch cams
            marker.GetComponent<MeshRenderer>().enabled = true;
            cam.GetComponent<Camera>().enabled = false;
            telecam.GetComponent<Camera>().enabled = true;

            // Move Marker


            // Tele off
            side1.GetComponent<teleport_to_basket>().teletrigger = false;
            side2.GetComponent<teleport_to_basket>().teletrigger = false;
            side3.GetComponent<teleport_to_basket>().teletrigger = false;
            side4.GetComponent<teleport_to_basket>().teletrigger = false;

        }


    }
}
