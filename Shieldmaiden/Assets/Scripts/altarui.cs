//Class that defines the behavior of the tutorial's UI.

//Import libraries.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarui : MonoBehaviour
{
    public GameObject objective1; //Variable that stores the objective's UI tick.

    public GameObject controlUI; //Variable that stores control's UI.

    public GameObject controlUI2; //Variable that stores control's UI.

    //Function starts when player collides with with sphere collider around altar.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            objective1.SetActive(true); //Shows objective's tick UI.

            //Shows controls UI.
            controlUI.SetActive(true); 
            controlUI2.SetActive(true);
        }
    }
}
