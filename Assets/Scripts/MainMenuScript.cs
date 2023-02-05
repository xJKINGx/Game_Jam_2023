using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("paly");
    }

    public void LoadControls()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
