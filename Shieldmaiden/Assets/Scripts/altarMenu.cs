//Class that defines the behavior of the altar's UI.

//Import libraries. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; //Boolean that defines whether the game is paused. 

    public GameObject altarMenuUI; //Variable that stores the altar's UI.

    public GameObject GodPower1; //Variable that stores the cool-down UI.


    // Update is called once per frame.
    void Update()
    {
        //Accesses the player script and stores it in new variable.
        GameObject Player = GameObject.Find("PlayerArmature");
        playerScript playerScript = Player.GetComponent<playerScript>();

        //If "Q" was pressed and player collided with altar:
        if (Input.GetKeyDown(KeyCode.Q)&& playerScript.altarPressed)
        {
            if (GameIsPaused)
            {
                Resume(); //If game is paused, resume. 
            }
            else 
            {
                Pause(); //If game is not paused, display altar's UI.
            }

            GodPower1.SetActive(true); //Displays cool-down UI. 
        } 
    }

    //Closes altar's UI and resumes game. 
    public void Resume()
    {
        altarMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Displays altar's UI and pauses game. 
    void Pause()
    {
        altarMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
