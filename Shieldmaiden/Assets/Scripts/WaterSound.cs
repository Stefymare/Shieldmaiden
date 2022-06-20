//Class that defines water sound effect behavior.

//Import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSound : MonoBehaviour
{
    //Function triggered when player enters sphere collider's radius.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Plays sound effect.
            GameObject WaterSound = GameObject.Find("WaterFX");
            AudioSource WaterFX = WaterSound.GetComponent<AudioSource>();
            WaterFX.Play();
        }
    }

    //Function triggered when player abandons sphere collider's radius.
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Stops sound effect.
            GameObject WaterSound = GameObject.Find("WaterFX");
            AudioSource WaterFX = WaterSound.GetComponent<AudioSource>();
            WaterFX.Stop();
        }
    }

}
