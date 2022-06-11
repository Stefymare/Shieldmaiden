using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSound : MonoBehaviour
{
    private void Update()
    {
        ChangeVolume();
    }
    void OnTriggerEnter(Collider col)
    {
        

        if (col.gameObject.tag == "Player")
        {
            GameObject WaterSound = GameObject.Find("Water_Fx");
            AudioSource WaterFX = WaterSound.GetComponent<AudioSource>();
            WaterFX.Play();


        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject WaterSound = GameObject.Find("Water_Fx");
            AudioSource WaterFX = WaterSound.GetComponent<AudioSource>();
            WaterFX.Stop();
        }
    }

    public void ChangeVolume()
    {
        StartCoroutine(ChangeVolumeCoroutine());
    }

    private IEnumerator ChangeVolumeCoroutine()
    {
        GameObject WaterSound = GameObject.Find("Water_Fx");
        AudioSource WaterFX = WaterSound.GetComponent<AudioSource>();

        while (WaterFX.volume < 0.08)
        {
            WaterFX.volume += 0.005f;
            yield return null;
        }
    }
}

