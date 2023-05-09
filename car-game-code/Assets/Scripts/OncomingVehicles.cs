using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingVehicles : MonoBehaviour
{   

    public float speed = 35.0f;


    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
