//Class that defines the bear's behavior.

//Import libraries. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearBehavior : MonoBehaviour
{
    public GameObject objective3; //Declares variable that stores the objective's UI.

    public AudioSource random; //Declares variable that stores audio source.

    public AudioClip[] audioClipArray; //Declares array to store audioclips.

    public enemyHealthManager enemyHealthManager; //Declares variable to acceses enemyHealthManager script.


    //Plays random audio clip from array.
    void Sounds()
    {
        random.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        random.PlayOneShot(random.clip);
    }

    // Start is called before the first frame update
    void Start()
    {
        random = GetComponent<AudioSource>(); //Stores audio source in variable.
    }

    //Function triggered when player enters sphere collider.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {     
            Sounds(); //Calls function.
            objective3.SetActive(true); //Displays objective3 tick. 
        }
    }
    
}
