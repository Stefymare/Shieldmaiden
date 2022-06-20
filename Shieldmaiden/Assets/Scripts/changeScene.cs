//Class that defines change scene behavior.

//Import libraries. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    //Loads scene. 
    public void Changemenuscene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
