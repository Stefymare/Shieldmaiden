//Class that defines the combat music's behavior.

//Import libraries. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatMusic : MonoBehaviour
{
    public AudioSource _audiosource; //Declares variable store audio source.

    private void Start()
    {
        _audiosource = GetComponent<AudioSource>(); //Stores audio source.
    }

   //Function triggered when player enters in sphere collider's radius. 
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Stops altar music.
            GameObject AltarMusic = GameObject.Find("AltarMusic");
            AudioSource AltarMusc = AltarMusic.GetComponent<AudioSource>();
            AltarMusc.volume = 0f;

            //Stops exploration music.
            GameObject ExplorationMusic = GameObject.Find("Music Exploration");
            AudioSource ExplortMusc = ExplorationMusic.GetComponent<AudioSource>();
            ExplortMusc.volume = 0f;

            //Plays combat music.
            _audiosource.Play();
        }
    }

    //Function trigerred when player abandons collider.
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Plays explroation music.
            GameObject ExplorationMusic = GameObject.Find("Music Exploration");
            AudioSource ExplortMusc = ExplorationMusic.GetComponent<AudioSource>();
            ExplortMusc.volume = 1f;

            //Stops combat music.
            _audiosource.Stop();
        }
    }
}
