using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // The speed at which the object moves
    public GameObject joystickHandle;  // The joystick handle object
    public Vector3 movementVector;  // The movement vector calculated by the joystick

    private bool isJoystickHeldDown = false;  // Flag indicating if the joystick is being held down
    private Vector3 joystickInitialPosition;  // The initial position of the joystick handle

    void Start()
    {
        joystickInitialPosition = joystickHandle.transform.position;
    }

    void Update()
    {
        if (isJoystickHeldDown)
        {
            Vector3 joystickCurrentPosition = joystickHandle.transform.position;
            Vector3 joystickDelta = joystickCurrentPosition - joystickInitialPosition;
            float joystickDistance = joystickDelta.magnitude;
            Vector3 joystickDirection = joystickDelta.normalized;

            if (joystickDistance > 0.1f)
            {
                movementVector = joystickDirection * moveSpeed * Time.deltaTime;
                transform.Translate(movementVector);
            }
        }
    }

    public void OnJoystickPointerDown()
    {
        isJoystickHeldDown = true;
        joystickInitialPosition = joystickHandle.transform.position;
    }

    public void OnJoystickPointerUp()
    {
        isJoystickHeldDown = false;
        joystickHandle.transform.position = joystickInitialPosition;
        movementVector = Vector3.zero;
    }
}
