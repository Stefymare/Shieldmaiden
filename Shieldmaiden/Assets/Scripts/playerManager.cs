using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{

    #region Singleton

    public static playerManager instance;
    public static int Damage;
    public playerScript playerScript;

    private void Awake()
    {
        instance = this;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        playerScript playerScript = player.GetComponent<playerScript>();

    }

    #endregion

    public GameObject player;

    private void Update()
    {
        Damage = playerScript.Damage;
    }

}
