
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject player;

    //offset from the player to camera
    public Vector3 offset;

    private void Start()
    {
        offset =  new Vector3(0, 5f, -3f);
    }


    private void LateUpdate()
    {
        //TransformPoint uses the offset position from the player Gameobject
        transform.position = player.transform.TransformPoint(offset);

        //camera will look at the player wherever it is located at
        transform.LookAt(player.transform);
    }
}
