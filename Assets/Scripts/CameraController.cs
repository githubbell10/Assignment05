using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
    public GameObject player;       // public so we can assign the player to this variable in the inspector
    Vector3 offset;                 // empty Vector3 to store the starting postion of the camera

    void Start()
    {
        // store camera's starting postion so we can keep the same offset as the ball moves
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;    // updates the camera's postion as the ball moves
    }
}