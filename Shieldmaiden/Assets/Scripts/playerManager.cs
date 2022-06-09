using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{

    #region Singleton

    public static playerManager instance;
    public static int Damage;
    public weaponEnabler weaponEnabler;

    private void Awake()
    {
        instance = this;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        weaponEnabler weaponEnabler = player.GetComponent<weaponEnabler>();

    }

    #endregion

    public GameObject player;

    private void Update()
    {
        Damage = weaponEnabler.Damage;
    }

}
