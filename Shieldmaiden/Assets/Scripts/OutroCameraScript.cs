using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutroCameraScript : MonoBehaviour
{


    private Camera cam;
    private Animator animator;
    private int panelnumber;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        panelnumber = animator.GetInteger("Panel");

        if (Input.GetMouseButtonDown(0))
        {
            panelnumber = panelnumber + 1;
            animator.SetInteger("Panel", panelnumber);

            if (panelnumber == 5)
            {
                Application.LoadLevel("MenuScene");
            }
        }
    }
}
