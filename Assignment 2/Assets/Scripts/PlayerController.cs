using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    private bool colBuilding;
    private PlayerControls playerControls;
    public GameObject cam;
    public GameObject player;
    public GameObject minimapObj;
    public GameObject tpcam;
    Vector3 pos;
    private float speed = 2.5f; //10f;
    private Vector3 moveDirection;
    private Collider collision;
    private Rigidbody rigidbody;
    private bool minimap;
    public bool interact;
    public bool checklist;
    public bool thirdperson;
    public GameObject mainplayer;
    public GameObject balloon;





    private void Awake()
    {
        playerControls = new PlayerControls();
        cam = GameObject.Find("/MainPlayer/Main Camera");
        player = GameObject.Find("/MainPlayer/Player");
        minimapObj = GameObject.Find("Canvas/Minimap");
        tpcam = GameObject.Find("MainPlayer/TPCamera");
        mainplayer = GameObject.Find("/MainPlayer");
        balloon = GameObject.Find("/Hot Air Balloon");
        pos = transform.position;
        minimap = false;
        interact = false;
        checklist = false;
        thirdperson = false;
    }


    private void OnEnable()
    {
        playerControls.Enable();
        moveDirection = cam.transform.forward;
        rigidbody = player.GetComponent<Rigidbody>();
    }


    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Start()
    {
        //collision = player.GetComponent<Collider>();


    }


    // Update is called once per frame
    void Update()
    {
        colBuilding = player.GetComponent<Collision>().collisionBuilding;

        Vector2 move = playerControls.Gameplay.test.ReadValue<Vector2>();

        float a = playerControls.Gameplay.a.ReadValue<float>();

        if (playerControls.Gameplay.a.triggered)
        {
            Debug.Log("A Pressed");
            if(minimap == false)
            {
                minimap = true;
            }
            else
            {
                minimap = false;
            }
        }

        if (playerControls.Gameplay.b.triggered)
        {
            Debug.Log("B Pressed");
            if(thirdperson == false)
            {
                cam.GetComponent<Camera>().enabled = false;
                tpcam.GetComponent<Camera>().enabled = true;
                //cam.SetActive(false);
                //tpcam.SetActive(true);
                thirdperson = true;

            }
            else
            {
                cam.GetComponent<Camera>().enabled = true;
                tpcam.GetComponent<Camera>().enabled = false;
                //cam.SetActive(true);
                //tpcam.SetActive(false);
                thirdperson = false;
            }
        }

        if (playerControls.Gameplay.x.triggered)
        {
            //Debug.Log("X Pressed");
            interact = true;

        }

        if (playerControls.Gameplay.y.triggered)
        {
            Debug.Log("Y Pressed");
            if (checklist == false)
            {
                checklist = true;
            }
            else
            {
                checklist = false;
            }

        }



        //Vector2 move = playerControls.Gameplay.Move.ReadValue<Vector2>();
        //Vector2 move = playerControls.Gameplay.MoveNew.ReadValue<Vector2>();
        //Vector3 moveDirection = new Vector3(move.x, 0, move.y);


        if(transform.parent != balloon.transform)
        {
            Vector3 forwardDirection = Vector3.Scale(cam.transform.forward, new Vector3(1, 0, 1)).normalized;
            Vector3 rightDirection = Vector3.Cross(Vector3.up, forwardDirection);
            moveDirection = forwardDirection * move.y + rightDirection * move.x;
            transform.position += moveDirection * speed * Time.deltaTime;
        }

        
        //rigidbody.velocity = moveDirection * speed;

        pos = transform.position;

        if (colBuilding == false)
        {
        transform.position += moveDirection * speed * Time.deltaTime;
        }
        else
        {
            transform.position += -moveDirection * 1;
        }

        if(minimap == true)
        {
            minimapObj.SetActive(true);
        }
        else
        {
            minimapObj.SetActive(false);
        }



        //transform.position += moveDirection * Time.deltaTime * horizontalSpeed;
        //Vector3 TeleportPose = new Vector3(player.transform.position.x+move.x,player.transform.position.y, player.transform.position.z+move.y);
        // player.transform.position = TeleportPose;
        //transform.position += moveDirection * speed * Time.deltaTime;
        //Debug.Log(move);

    }

}
