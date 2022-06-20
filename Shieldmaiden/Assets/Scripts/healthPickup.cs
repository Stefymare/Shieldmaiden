//Class that defines the health pick-ups' behavior.

//Import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPickup : MonoBehaviour
{
    public playerScript _playerScript; //Declares variable to access the player's script.

    //FUnction starts when player collides with health-pick up.
    void OnCollisionEnter(Collision col)
    {
        //Acceses player's script.
        GameObject Player = GameObject.Find("PlayerArmature");
        _playerScript = Player.GetComponent<playerScript>();

        if (col.gameObject.tag == "Player")
        {
            //Plays sound effect.
            GameObject HealthSound = GameObject.Find("HealthFX");
            AudioSource HealthFX = HealthSound.GetComponent<AudioSource>();
            HealthFX.Play();

            //Sets player's health to not go above 100.
            if (_playerScript.playerHealth < 100)
            {
                _playerScript.playerHealth += 10;
            }
            if(_playerScript.playerHealth == 105)
            {
                _playerScript.playerHealth = 100;
            }
            
            Destroy(this.gameObject); //Destroys pick-up.
        }
    }
}
