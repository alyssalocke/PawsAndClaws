using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("go to menu");
            SceneManager.LoadScene("StartScreen");
        }
    }

    public void PlayGame()
    {
        Debug.Log("play game");
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void MainMenu()
    {
        Debug.Log("go to menu");
        SceneManager.LoadScene("StartScreen");
    }
}
