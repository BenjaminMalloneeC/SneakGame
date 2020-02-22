using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Allows for designer to change the what camera follows
    public CameraFollow cameraFollow;

    //Allows designer to change what spirte/player the camera follows
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the camera up to start following the player
        cameraFollow.Setup(() => playerTransform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
