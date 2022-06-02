using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarBehavior : MonoBehaviour
{
    public bool powerChosen = false;

    public void ChoosePower()
    {
        powerChosen = true;
        Debug.Log("PowerChosen"+ powerChosen);
    }
}
