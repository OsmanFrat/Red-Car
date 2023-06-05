using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] readonly Vector3 offset1 = new Vector3(0, 5, -7);
    [SerializeField] readonly Vector3 offset2 = new Vector3(0,3,1);
    [SerializeField] readonly Vector3 offset3 = new Vector3(10,6,0);


    void LateUpdate()
    {
        transform.position = player.transform.position + offset1;
    }

}
