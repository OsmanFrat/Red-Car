using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{


    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void pauseScreen()
    {
        SceneManager.LoadScene("Main");
    }

    public void coop()
    {
        SceneManager.LoadScene("level002");
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
 
}
