using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPickup : MonoBehaviour
{


    public playerScript _playerScript;


    void OnCollisionEnter(Collision col)
    {
          
        GameObject Player = GameObject.Find("PlayerArmature");
        _playerScript = Player.GetComponent<playerScript>();
        if (col.gameObject.tag == "Player")
        {
            GameObject HealthSound = GameObject.Find("HealthFX");
            AudioSource HealthFX = HealthSound.GetComponent<AudioSource>();
            HealthFX.Play();
            if (_playerScript.playerHealth < 100)
            {
                _playerScript.playerHealth += 10;
            }
            if(_playerScript.playerHealth == 105)
            {
                _playerScript.playerHealth = 100;
            }
            Debug.Log(_playerScript.playerHealth);
            Destroy(this.gameObject);
           
            
        }
    }
}
