//Class that defines the altar's behavior.

//Import libraries. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarBehavior : MonoBehaviour
{
    //Boolean that defines whether the god power has been chosen.
    public bool powerChosen = false;

    //This function activates when the god pwoer button is pressed:
    public void ChoosePower()
    {
        //Plays thunder sound effect.
        GameObject ThunderSound = GameObject.Find("ThunderFX");
        AudioSource ThunderFX = ThunderSound.GetComponent<AudioSource>();
        ThunderFX.Play();

        //Plays altar music.
        GameObject AltarMusic = GameObject.Find("AltarMusic");
        AudioSource AltarMusc = AltarMusic.GetComponent<AudioSource>();
        AltarMusc.Play();

        //Stops exploration music.
        GameObject ExplorationMusic = GameObject.Find("Music Exploration");
        AudioSource ExplortMusc = ExplorationMusic.GetComponent<AudioSource>();
        ExplortMusc.volume = 0f;

        powerChosen = true; //Sets boolean to true. 

        //Automatically closes altar UI:
        GameObject AltarUI = GameObject.Find("Canvas");
        altarMenu altarScript = AltarUI.GetComponent<altarMenu>();
        altarScript.Resume();   
    }
}
