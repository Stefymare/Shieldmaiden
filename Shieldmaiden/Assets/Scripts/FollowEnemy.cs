using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        GameObject Enemy = GameObject.Find("Troll_redo_v8");
        transform.position = Enemy.transform.position;

    }
}
