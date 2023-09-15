using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport_off_basket : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerCameraGameObject;
    public GameObject bottom;
    public GameObject balloon;
    public Color activeColor;
    public Color inactiveColor;
    public bool colorChanging = false;
    private MeshRenderer myRenderer;
    public float myTimer = 0f;
    public float verticalSpeed = 0.1f;
    public float maxHeight;
    public float minHeight;
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = inactiveColor;
        bottom = GameObject.Find("/Hot Air Balloon/Basket/bottom");
        balloon = GameObject.Find("/Hot Air Balloon");
        minHeight = balloon.transform.position.y;
        maxHeight = balloon.transform.position.y + 25f;
        playerCameraGameObject = GameObject.Find("/MainPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        if (colorChanging)
        {
            myRenderer.material.color = Color.Lerp(myRenderer.material.color, activeColor, Time.deltaTime / 5f);
            myTimer += Time.deltaTime;

            if (myTimer >= 5f)
            {
                if (balloon.transform.position.y > minHeight)
                {
                    playerCameraGameObject.transform.position += new Vector3(0, -1f * Time.deltaTime, 0);
                    balloon.transform.position += new Vector3(0, -1 * Time.deltaTime, 0);
                }
                else
                {
                    OnPointerExit();
                    //Teleport player to location of TeleportCube
                    Vector3 TeleportPose = new Vector3((bottom.transform.position.x + 3), playerCameraGameObject.transform.position.y, bottom.transform.position.z + 3);
                    playerCameraGameObject.transform.position = TeleportPose;
                }
                
            }
        }
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
            if (balloon.transform.position.y < (minHeight + 1f))
            {
                myTimer = 0f;
                colorChanging = false;
                myRenderer.material.color = inactiveColor;
                //myRenderer.material.color = inactiveColor;
            }
        }
    }
}
