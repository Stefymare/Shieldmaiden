using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject altarMenuUI;

    

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
        }
    }

    public void Resume()
    {
        altarMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;

    }

    void Pause()
    {
        altarMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;

    }

}
