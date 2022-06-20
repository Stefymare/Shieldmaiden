//Class that defines fade in and out animation's behavior.

//Import libraries.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    private Animator m_animator; //Declares variable to access animator.

    public float currentTime = 0f; //Declares variable to store current time.
    float startingTime = 2f; //Declares variable to store starting time.

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>(); //Acceses animator.
        currentTime = startingTime; //Matches current time to starting time.
    }
    private void Update()
    {
        currentTime -= 1 * Time.deltaTime; //Starts timer.

        //If timer stops, calls function.
        if (currentTime <= 0f)
        {
            FadeOut();
        }
    }

    //Plays animation.
    void FadeOut()
    {
        m_animator.SetTrigger("FadeOut");
    }
}
