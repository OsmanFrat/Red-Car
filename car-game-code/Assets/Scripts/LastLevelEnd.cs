using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastLevelEnd : MonoBehaviour
{
        private void OnTriggerEnter(Collider collider) {
        GameObject hitObj = collider.gameObject;
        if(hitObj.tag == "Player")
        {
            SceneManager.LoadScene("Main");
        }
    }
}
