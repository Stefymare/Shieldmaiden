using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarBehavior : MonoBehaviour
{
    public bool powerChosen = false;

    public void ChoosePower()
    {

        GameObject ThunderSound = GameObject.Find("ThunderFX");
        AudioSource ThunderFX = ThunderSound.GetComponent<AudioSource>();
        ThunderFX.Play();

        GameObject AltarMusic = GameObject.Find("AltarMusic");
        AudioSource AltarMusc = AltarMusic.GetComponent<AudioSource>();
        AltarMusc.Play();

        GameObject ExplorationMusic = GameObject.Find("Music Exploration");
        AudioSource ExplortMusc = ExplorationMusic.GetComponent<AudioSource>();
        ExplortMusc.volume = 0f;

        powerChosen = true;
        GameObject AltarUI = GameObject.Find("Canvas");
        altarMenu altarScript = AltarUI.GetComponent<altarMenu>();
        altarScript.Resume();
        Debug.Log("PowerChosen"+ powerChosen);
        
    }


}
