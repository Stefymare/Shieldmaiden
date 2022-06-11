using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarBehavior : MonoBehaviour
{
    public bool powerChosen = false;

    public void ChoosePower()
    {
        GameObject ThunderSound = GameObject.Find("Thunder_Fx");
        AudioSource ThunderFX = ThunderSound.GetComponent<AudioSource>();
        ThunderFX.Play();
        powerChosen = true;
        GameObject AltarUI = GameObject.Find("Canvas");
        altarMenu altarScript = AltarUI.GetComponent<altarMenu>();
        altarScript.Resume();
        Debug.Log("PowerChosen"+ powerChosen);
    }
}
