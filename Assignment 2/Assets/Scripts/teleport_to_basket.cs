using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport_to_basket : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerCameraGameObject;
    public GameObject bottom;
    public Color activeColor;
    public Color inactiveColor;
    public bool colorChanging = false;
    private MeshRenderer myRenderer;
    public float myTimer = 0f;
    public bool inter;
    public bool teletrigger;
    public GameObject balloon;
    public bool telenow;
    public GameObject marker;
    Vector3 markerpos;
    public GameObject cam;
    public GameObject telecam;
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = inactiveColor;
        bottom = GameObject.Find("/Hot Air Balloon/Basket/bottom");
        playerCameraGameObject = GameObject.Find("/MainPlayer");
        balloon = GameObject.Find("/Hot Air Balloon");
        marker = GameObject.Find("/Marker");
        cam = GameObject.Find("/MainPlayer/Main Camera");
        telecam = GameObject.Find("/TeleCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (colorChanging)
        {
            myRenderer.material.color = Color.Lerp(myRenderer.material.color, activeColor, Time.deltaTime / 3f);
            myTimer += Time.deltaTime;


            inter = playerCameraGameObject.GetComponent<PlayerController>().interact;
            if (myTimer >= 3f && inter == true)
            {
                //Teleport player to location of TeleportCube
                Vector3 TeleportPose = new Vector3((bottom.transform.position.x), playerCameraGameObject.transform.position.y, bottom.transform.position.z);
                //Debug.Log(TeleportPose);
                //Debug.Log(transform.position);
                playerCameraGameObject.transform.position = TeleportPose;
                playerCameraGameObject.transform.parent = balloon.transform;
                teletrigger = true;
                playerCameraGameObject.GetComponent<PlayerController>().interact = false;
            }
        }

        telenow = marker.GetComponent<MoveMarker>().telenow;

        if(telenow == true)
        {
            markerpos = marker.GetComponent<Transform>().position;
            balloon.transform.position = markerpos;
            playerCameraGameObject.transform.parent = null;


            marker.GetComponent<MeshRenderer>().enabled = false;
            cam.GetComponent<Camera>().enabled = true;
            telecam.GetComponent<Camera>().enabled = false;

            Vector3 TeleportPose = new Vector3((bottom.transform.position.x + 3), playerCameraGameObject.transform.position.y, bottom.transform.position.z + 3);
            playerCameraGameObject.transform.position = TeleportPose;
            marker.GetComponent<MoveMarker>().telenow = false;
        }


        /*Debug.Log(playerCameraGameObject.transform.parent, balloon);

        if(playerCameraGameObject.transform.parent == balloon)
        {
            Debug.Log("HERE!");
            teletrigger = true;
        }*/
    }

    public void OnPointerEnter()
    {
        GazeAt(true);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        GazeAt(false);
    }

    public void GazeAt(bool gazing)
    {
        if (gazing)
        {
            colorChanging = true;
            //myRenderer.material.color = activeColor;
        }
        else
        {
            myTimer = 0f;
            colorChanging = false;
            myRenderer.material.color = inactiveColor;
            //myRenderer.material.color = inactiveColor;
        }
    }
}
