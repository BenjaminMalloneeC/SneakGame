using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Function to get the camera following position
    public Func<Vector3> GetCameraFollowPositionFunc;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Setup(Func<Vector3> GetCameraFollowPositionFunc)
    {
        //Gets and saves the camera follow position function
        this.GetCameraFollowPositionFunc = GetCameraFollowPositionFunc;
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the player positions and follows the player
        Vector3 cameraFollowPosition = GetCameraFollowPositionFunc();
        cameraFollowPosition.z = transform.position.z;
        transform.position = cameraFollowPosition;
    }
}
