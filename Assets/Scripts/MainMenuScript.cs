using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public GameObject controlCanvas, mainMenuCanvas;
    
    public void Start() {
        LoadMainMenu();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("paly");
    }

    public void LoadControls()
    {
        mainMenuCanvas.SetActive(false);
        controlCanvas.SetActive(true);
    }

    public void LoadMainMenu() {
        mainMenuCanvas.SetActive(true);
        controlCanvas.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
