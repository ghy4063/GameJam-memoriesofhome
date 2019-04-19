using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization


    // grabs the player's transform to follow
    [Header("Player to follow")]
    public Transform playerTransform;
    //speed at which it follows
    [Header("Speed at which the camera follows the player")]
    public float cameraMoveSpeed;
    //current transform
    private Vector3 cameraPosition;
    // set values for the camera position
    [Header("Camera Position")]
    public float cameraX;
    public float cameraY;
    public float cameraZ;

    void Start()
    {//sets the camera's position to the set values
        cameraPosition= new Vector3(cameraX,cameraY,cameraZ);
    }
    // makes sure the camera is focused on the player all the time
    void Update()
    {
        this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, playerTransform.position + cameraPosition, cameraMoveSpeed * Time.deltaTime);
    }
}
