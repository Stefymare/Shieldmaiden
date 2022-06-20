//Class that defines pause menu's behavior.

//Import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; //Declares boolean to set whether game has been paused.

    //Declares variables to store UIs.
    public GameObject pauseMenuUI;
    public GameObject ingameUI;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        //If escape is pressed:
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused) //If game is paused, resume.
            {
                Resume();
            }
            else //If game is not paused, pause.
            {
                Pause();
            }
        }
    }

    //Closes pause menu UI and resumes game.
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        ingameUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
    }

    //Displays pause menu UI and pauses the game.
    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        ingameUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;

    }

    //Loads menu scene.
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }

    //Exits game (loads menu scene).
    public void Exit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }

    //Quits game.
    public void QuitGame()
    {
        Application.Quit();
    }
}
