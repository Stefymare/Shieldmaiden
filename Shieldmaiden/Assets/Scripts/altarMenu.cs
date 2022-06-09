using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject altarMenuUI;

    public GameObject GodPower1;



    

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.Find("PlayerArmature");
        playerScript playerScript = Player.GetComponent<playerScript>();



        if (Input.GetKeyDown(KeyCode.Q)&& playerScript.altarPressed)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else 
            {
                Pause();
            }
            GodPower1.SetActive(true);
        }
        
    }

    public void Resume()
    {
        altarMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Pause()
    {
        altarMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

}
