using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextEvent : MonoBehaviour
{
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    
    public void exitGame()
    {
        SceneManager.LoadScene("Exit");
    }
    public void Starter_Scene()
    {
        SceneManager.LoadScene("Starter Scene");
    }

    public void GoBacktoInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
