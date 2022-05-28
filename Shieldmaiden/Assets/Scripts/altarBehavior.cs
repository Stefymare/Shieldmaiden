using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarBehavior : MonoBehaviour
{
    public bool thorPower = false;
    public void GodPower()
    {
        thorPower = true;
        Debug.Log(thorPower);
    }
}
