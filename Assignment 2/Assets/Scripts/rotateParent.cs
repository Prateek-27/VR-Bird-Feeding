using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateParent : MonoBehaviour
{
    private Transform cameratrans;
    private GameObject player;
    private void Start()
    {
        // Get the child's transform component

        player = GameObject.Find("/MainPlayer/Player");
        cameratrans = transform.GetChild(0);
        


        //player = GameObject.Find("/Player");
        //cam = GameObject.Find("/Player/Main Camera");

        //cameratrans = cam.transform;


    }

    private void Update()
    {

        
    // Get the child's rotation and only use the y-axis rotation
    Quaternion childRotation = cameratrans.rotation;
    float yRotation = childRotation.eulerAngles.y;



    if(childRotation != transform.localRotation) {
        // Set the parent's rotation to only rotate around the y-axis
        player.transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
    }

    

}
}



