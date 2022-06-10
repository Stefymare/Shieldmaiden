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
            _playerScript.playerHealth += 10;
            Debug.Log(_playerScript.playerHealth);
            Destroy(this.gameObject);
           
            
        }
    }
}
