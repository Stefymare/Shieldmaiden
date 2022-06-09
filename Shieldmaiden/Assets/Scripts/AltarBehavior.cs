using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarBehavior : MonoBehaviour
{
    public bool powerChosen = false;

    public void ChoosePower()
    {
        powerChosen = true;
        GameObject AltarUI = GameObject.Find("Canvas");
        altarMenu altarScript = AltarUI.GetComponent<altarMenu>();
        altarScript.Resume();
        Debug.Log("PowerChosen"+ powerChosen);
    }
}
