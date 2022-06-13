using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatui : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            pauseMenuUI.SetActive(true);
        }
    }
}
