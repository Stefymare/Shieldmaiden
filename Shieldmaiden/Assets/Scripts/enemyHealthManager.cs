using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealthManager : MonoBehaviour
{
    public GameObject objective2;
    public bool defeated = false;
    // Update is called once per frame
    void Update()
    {
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

        if(_enemy1.health <= 0 && _enemy2.health <= 0 && _enemy3.health <= 0 && _enemy4.health <= 0 && _enemy5.health <= 0)
        {
            WinObjective();
            defeated = true;
        }
        
    }
    void WinObjective()
    {
        objective2.SetActive(true);
    }
}
