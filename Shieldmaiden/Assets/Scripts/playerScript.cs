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

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Altar")
        {
            altarPressed = true;
            Debug.Log(altarPressed);
        }
    }
    public void GodPower1()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            lightningparticles.SetActive(true);
            godPower1 = true;
            Damage = 20;
        }
        playerScript weaponEnabler = player.GetComponent<playerScript>();

        if(godPower1 == false)
        {
            lightningparticles.SetActive(false);
            Damage = 10;
        }
    }
}
