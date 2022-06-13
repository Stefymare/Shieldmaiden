using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{

    private Animator m_animator;

    public float currentTime = 0f;
    float startingTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        currentTime = startingTime;
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
        m_animator.SetTrigger("FadeOut");
    }
}
