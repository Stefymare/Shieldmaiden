using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeOut : MonoBehaviour
{

    private Animator m_animator;

    public float currentTime = 0f;
    float startingTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        currentTime = startingTime;

        m_animator.enabled = false;
    }
    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 0f)
        {
            FadeOut();
        }
    }
    // Update is called once per frame
    void FadeOut()
    {
        m_animator.enabled = true;
    }
}
