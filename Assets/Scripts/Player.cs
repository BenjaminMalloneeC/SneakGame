﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Create a variable for our transform component
    private Transform tf;

    //Create a variable for the degree we rrotate in one frame draw
    public float turnSpeed = 1.0f;
    public float movementSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Load our transform component into our variable
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate left when pushing left arrow
            tf.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate right when pushing left arrow
            tf.Rotate(0, 0, -turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Moves forward in local space
            tf.position += tf.up * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Moves backwards in local space
            tf.position -= tf.up * movementSpeed * Time.deltaTime;
        }
    }
}
