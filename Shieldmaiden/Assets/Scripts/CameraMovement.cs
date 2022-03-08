//Class that defines the camera's behavior.

//Import libraries.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target; //Declares variable to hold the target's Transform information.
    public Vector3 offset; //Declares variable to store the distance between the camera and the player.

    // Updates camera's position
    void Update()
    {
        transform.position = target.position + offset; //Initializes the position of the camera to the target's position plus the offset.
    }
}
