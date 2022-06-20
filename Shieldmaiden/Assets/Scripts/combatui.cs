//Class that defines combat tutorial UI's behavior.

//Import libraries. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatui : MonoBehaviour
{
    public GameObject combatUI; //Declares variable to store combat UI.

    //Function triggered when player enters sphere collider radius.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            combatUI.SetActive(true); //Displays combat UI.
        }
    }
}
