using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarui : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public GameObject pauseMenuUI2;
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            pauseMenuUI.SetActive(true);
            pauseMenuUI2.SetActive(true);
        }
    }
}
