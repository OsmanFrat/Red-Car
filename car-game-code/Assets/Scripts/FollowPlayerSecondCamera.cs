using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerSecondCamera : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0,3,-1);
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to player's position 
        transform.position = player.transform.position + offset;
    }
}
