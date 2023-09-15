using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up : MonoBehaviour
{
    public GameObject playerCameraGameObject;
    public GameObject balloon;
    public float maxHeight;
    public Color activeColor;
    public Color inactiveColor;
    public bool colorChanging = false;
    private MeshRenderer myRenderer;
    public float myTimer = 0f;
    public float verticalSpeed = 0.1f; 

    // Start is called before the first frame update
    void Start()
    {
        
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = inactiveColor;
        balloon = GameObject.Find("/Hot Air Balloon");
        maxHeight = balloon.transform.position.y + 25f;
        playerCameraGameObject = GameObject.Find("/Player");
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

                if (balloon.transform.position.y <= maxHeight)
                {
                    playerCameraGameObject.transform.position += new Vector3(0, 2 * Time.deltaTime, 0);
                    balloon.transform.position += new Vector3(0, 2 * Time.deltaTime, 0);
                }
                else
                {
                    OnPointerExit();
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
            if(balloon.transform.position.y >= (maxHeight - 2f)) { 
                myTimer = 0f;
                myRenderer.material.color = inactiveColor;
                colorChanging = false;
                
                //myRenderer.material.color = inactiveColor;
            }
        }
    }

}
