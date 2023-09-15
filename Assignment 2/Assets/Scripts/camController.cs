using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour
{
    private PlayerControls playerControls;

    Vector3 pos;
    public float speed = 50.0f; //10.0f;
    private Vector3 moveDirection;



    private void Awake()
    {
        playerControls = new PlayerControls();
        pos = transform.position;
    }


    private void OnEnable()
    {
        playerControls.Enable();
        moveDirection = transform.forward;
    }


    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = playerControls.Gameplay.test.ReadValue<Vector2>();
        /*
        float a = playerControls.Gameplay.a.ReadValue<float>();

        if (playerControls.Gameplay.a.triggered)
        {
            Debug.Log("A Pressed");
        }

        if (playerControls.Gameplay.b.triggered)
        {
            Debug.Log("B Pressed");
        }

        if (playerControls.Gameplay.x.triggered)
        {
            Debug.Log("X Pressed");
        }

        if (playerControls.Gameplay.y.triggered)
        {
            Debug.Log("Y Pressed");
        }
        */


        //Vector2 move = playerControls.Gameplay.Move.ReadValue<Vector2>();
        //Vector2 move = playerControls.Gameplay.MoveNew.ReadValue<Vector2>();
        //Vector3 moveDirection = new Vector3(move.x, 0, move.y);

        Vector3 forwardDirection = Vector3.Scale(transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 rightDirection = Vector3.Cross(Vector3.up, forwardDirection);
        moveDirection = forwardDirection * move.y + rightDirection * move.x;

        transform.position += moveDirection * speed * Time.deltaTime;

        //transform.position += moveDirection * Time.deltaTime * horizontalSpeed;
        //Vector3 TeleportPose = new Vector3(player.transform.position.x+move.x,player.transform.position.y, player.transform.position.z+move.y);
        // player.transform.position = TeleportPose;

        //Debug.Log(move);
    }
}
