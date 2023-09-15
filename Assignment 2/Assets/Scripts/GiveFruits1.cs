using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveFruits1 : MonoBehaviour
{
    public GameObject player;
    public GameObject bottom;
    //public GameObject mainPlayer;
    public GameObject fruitbasket;
    public GameObject parent;
    public GameObject hand;
    public GameObject cam;

    public GameObject bub;
    public Color activeColor;
    public Color inactiveColor;
    public bool colorChanging = false;
    private MeshRenderer myRenderer;
    public float myTimer = 0f;
    public int counter;
    public bool counted = false;
    public bool inhand = false;


    public bool inzonebub = false;
    public bool onzonebase = false;
    bool bird1Col = false;
    bool bird2Col = false;

    bool inter;
    public Vector3 scale;


    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        inactiveColor = myRenderer.material.color;
        activeColor = Color.green;
        bottom = GameObject.Find("/MainPlayer/Basket/basketbase");
        player = GameObject.Find("/MainPlayer/Player");
        fruitbasket = GameObject.Find("/MainPlayer/Basket");
        parent = GameObject.Find("/MainPlayer");
        hand = GameObject.Find("/MainPlayer/Player/Hand");
        cam = GameObject.Find("/MainPlayer/Main Camera");
        bub = GameObject.Find("/Zones/Zone2/zone2Bubble");
        scale = transform.localScale;
        counter = 0;
        //inzonebub = player.GetComponent<Collision>().inZone2;
        //onzonebase = player.GetComponent<Collision>().onZone2base;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.gameObject == parent)
        {
            if (colorChanging)
            {
                myRenderer.material.color = Color.Lerp(myRenderer.material.color, activeColor, Time.deltaTime / 3f);
                myTimer += Time.deltaTime;


                inter = parent.GetComponent<PlayerController>().interact;
                if (myTimer >= 3f && inter == true)
                {
                    //Teleport player to location of TeleportCube
                    Vector3 TeleportPose = new Vector3((hand.transform.position.x + 0.4f), (hand.transform.position.y + 0.2f), hand.transform.position.z + 0.5f);
                    transform.position = TeleportPose;
                    //transform.parent = hand.transform;
                    transform.localScale = scale * 0.7f;
                    //counted = true;
                    //counter++;
                    parent.GetComponent<PlayerController>().interact = false;
                    inter = false;
                    inhand = true;

                }

            }

            keepitCentered(inhand);

        }


        // Feed it 
        inzonebub = player.GetComponent<Collision>().inZone2;
        onzonebase = player.GetComponent<Collision>().onZone2base;
        bird1Col = bub.GetComponent<birdCollision2>().bird2;
        bird2Col = bub.GetComponent<birdCollision2>().bird22;

        if (onzonebase == true && inhand == true)
        {

            if (bird1Col == true || bird2Col == true)
            {
                Debug.Log("DESTROY!");
                fruitbasket.GetComponent<FruitCounter>().strawberryCount -= 1f;
                fruitbasket.GetComponent<FruitCounter>().strawberryFed += 1f;
                Destroy(gameObject);
            }
        }


    }

    public void keepitCentered(bool h)
    {
        if (h == true)
        {
            Vector3 TeleportPose = new Vector3((hand.transform.position.x + 0.4f), (hand.transform.position.y + 0.2f), hand.transform.position.z + 0.5f);
            transform.position = TeleportPose;
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
