using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSound : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            GameObject WaterSound = GameObject.Find("WaterFX");
            AudioSource WaterFX = WaterSound.GetComponent<AudioSource>();
            WaterFX.Play();
        }
    }
    private void OnTriggerExit(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            GameObject WaterSound = GameObject.Find("WaterFX");
            AudioSource WaterFX = WaterSound.GetComponent<AudioSource>();
            WaterFX.Stop();
        }
    }

}
