using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,5,6);
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to player's position 
        transform.position = player.transform.position + offset;
    }
}
