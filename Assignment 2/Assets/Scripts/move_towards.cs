using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_towards : MonoBehaviour
{
    public GameObject playerCameraGameObject;
    public GameObject bottom;
    public GameObject balloon;
    public Color activeColor;
    public Color inactiveColor;
    public bool gaze = false;
    private MeshRenderer myRenderer;
    public float myTimer = 0f;
    public float HorizontalSpeed = 0.1f;
    public float maxHeight;
    public float minHeight;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = inactiveColor;
        bottom = GameObject.Find("/Hot Air Balloon/Basket/bottom");
        balloon = GameObject.Find("/Hot Air Balloon");
        minHeight = balloon.transform.position.y;
        maxHeight = balloon.transform.position.y+25f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gaze)
        {

            playerCameraGameObject.transform.position += new Vector3(1f * Time.deltaTime, 0, 0);
            balloon.transform.position += new Vector3(1f * Time.deltaTime, 0, 0);
            //transform.position += new Vector3(1f * Time.deltaTime, 0, 0);
            myRenderer.material.color = activeColor;
            if (balloon.transform.position.y > minHeight)
            {
                
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
            gaze = true;
            //myRenderer.material.color = activeColor;
        }
        else
        {
            if (balloon.transform.position.y < (minHeight + 1f))
            {
                gaze = false;
                myRenderer.material.color = inactiveColor;
                //myRenderer.material.color = inactiveColor;
            }
        }
    }
}
