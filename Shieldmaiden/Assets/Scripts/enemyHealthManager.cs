//Class that manages the enemies' health.

//Import libraries.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealthManager : MonoBehaviour
{
    public GameObject objective2; //Declares ariable that stores the objective's UI tick.

    public bool defeated = false; //Declares boolean to set whether enemies have been defeated.

    // Update is called once per frame
    void Update()
    {
        //Finds enemies and acceses their scripts.
        GameObject Enemy1 = GameObject.Find("Troll_redo_v8");
        enemyBehavior _enemy1 = Enemy1.GetComponent<enemyBehavior>();

        GameObject Enemy2 = GameObject.Find("Troll_redo_v8 (1)");
        enemyBehavior _enemy2 = Enemy2.GetComponent<enemyBehavior>();

        GameObject Enemy3 = GameObject.Find("Troll_redo_v8 (2)");
        enemyBehavior _enemy3 = Enemy3.GetComponent<enemyBehavior>();

        GameObject Enemy4 = GameObject.Find("Troll_redo_v8 (3)");
        enemyBehavior _enemy4 = Enemy4.GetComponent<enemyBehavior>();

        GameObject Enemy5 = GameObject.Find("Troll_redo_v8 (4)");
        enemyBehavior _enemy5 = Enemy5.GetComponent<enemyBehavior>();

        //If the health of all of the enemies are equal or smaller than 0:
        if(_enemy1.health <= 0 && _enemy2.health <= 0 && _enemy3.health <= 0 && _enemy4.health <= 0 && _enemy5.health <= 0)
        {
            WinObjective(); //Calls function.
            defeated = true; //Sets boolean to true.
        }
    }

    //Displays objective tick UI.
    void WinObjective()
    {
        objective2.SetActive(true);
    }
}
