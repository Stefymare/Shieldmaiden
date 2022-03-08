using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public void Changemenuscene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
