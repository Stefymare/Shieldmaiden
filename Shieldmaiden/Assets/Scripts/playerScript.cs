using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public bool altarPressed = false;
    public bool godPower1 = false;
    [SerializeField] public int Damage = 10;
    public GameObject player;
    public GameObject lightningparticles;
    public weaponEnabler weaponEnabler;

    private void Start()
    {
        weaponEnabler weaponEnabler = player.GetComponent<weaponEnabler>();

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Altar")
        {
            altarPressed = true;
            Debug.Log(altarPressed);
        }
    }
   
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            lightningparticles.SetActive(true);
            godPower1 = true;
            Damage = 20;
            Debug.Log("GodPowerActivated");
        }
        if (weaponEnabler.Dezactivate == true) 
        {
            godPower1 = weaponEnabler.GodPower1;
        }
        if(godPower1 == false)
        {
            lightningparticles.SetActive(false);
            Damage = 10;
            Debug.Log("GodPowerDezactivated");

        }
    }
}
