using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFruits1 : MonoBehaviour
{
    public GameObject playerCameraGameObject;
    public GameObject bottom;
    //public GameObject mainPlayer;
    public GameObject fruitbasket;
    public Color activeColor;
    public Color inactiveColor;
    public bool colorChanging = false;
    private MeshRenderer myRenderer;
    public float myTimer = 0f;
    public int counter;
    public bool counted = false;

    public GameObject parent;
    public GameObject hand;

    bool inter;


    public Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        inactiveColor = myRenderer.material.color;
        activeColor = Color.green;
        bottom = GameObject.Find("/MainPlayer/Basket/basketbase");
        playerCameraGameObject = GameObject.Find("/MainPlayer");
        fruitbasket = GameObject.Find("/MainPlayer/Basket");
        scale = transform.localScale;
        counter = 0;

        parent = GameObject.Find("/MainPlayer");
        hand = GameObject.Find("/MainPlayer/Player/Hand");
    }

    // Update is called once per frame
    void Update()
    {
        if (colorChanging)
        {
            myRenderer.material.color = Color.Lerp(myRenderer.material.color, activeColor, Time.deltaTime / 3f);
            myTimer += Time.deltaTime;

            if (transform.parent.gameObject != parent)
            {
                inter = parent.GetComponent<PlayerController>().interact;
                if (myTimer >= 3f && inter == true)
                {
                    //Teleport player to location of TeleportCube
                    Vector3 TeleportPose = new Vector3((bottom.transform.position.x - 0.2f), (bottom.transform.position.y + 0.2f), bottom.transform.position.z - 0.2f);
                    transform.position = TeleportPose;
                    transform.parent = parent.transform;
                    transform.localScale = scale * 0.5f;
                    counted = true;
                    updateCounter(counted);
                    counter++;
                    //Debug.Log(transform.parent.gameObject == parent);
                    parent.GetComponent<PlayerController>().interact = false;
                    inter = false;

                }
            }


        }

    }

    public void updateCounter(bool c)
    {
        if (c == true)
        {
            fruitbasket.GetComponent<FruitCounter>().strawberryCount += 1f; // 
            c = false;
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
            myTimer = 0f;
            colorChanging = false;
            myRenderer.material.color = inactiveColor;
            //myRenderer.material.color = inactiveColor;
        }
    }
}
