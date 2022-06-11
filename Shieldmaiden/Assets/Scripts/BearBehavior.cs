using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearBehavior : MonoBehaviour
{
    public AudioSource random;
    public AudioClip[] audioClipArray;
    // Start is called before the first frame update
    void Start()
    {
        random = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col)
    {


        if (col.gameObject.tag == "Player")
        {
            Sounds();


        }
    }


    void Sounds()
    {
        random.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        random.PlayOneShot(random.clip);
    }
}
