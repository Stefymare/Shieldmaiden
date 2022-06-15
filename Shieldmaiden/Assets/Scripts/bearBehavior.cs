using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearBehavior : MonoBehaviour
{

    public AudioSource random;
    public AudioClip[] audioClipArray;

    void Sounds()
    {

        random.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        random.PlayOneShot(random.clip);
    }
    // Start is called before the first frame update
    void Start()
    {
        random = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            
            Sounds();
        }
    }
    
}
