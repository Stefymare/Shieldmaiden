using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatMusic : MonoBehaviour
{

    public AudioSource _audiosource;
    private void Start()
    {
        _audiosource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            GameObject AltarMusic = GameObject.Find("AltarMusic");
            AudioSource AltarMusc = AltarMusic.GetComponent<AudioSource>();
            AltarMusc.volume = 0f;

            GameObject ExplorationMusic = GameObject.Find("Music Exploration");
            AudioSource ExplortMusc = ExplorationMusic.GetComponent<AudioSource>();
            ExplortMusc.volume = 0f;

            _audiosource.Play();
        }
    }
    private void OnTriggerExit(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            GameObject ExplorationMusic = GameObject.Find("Music Exploration");
            AudioSource ExplortMusc = ExplorationMusic.GetComponent<AudioSource>();
            ExplortMusc.volume = 1f;
            _audiosource.Stop();
        }
    }
}
