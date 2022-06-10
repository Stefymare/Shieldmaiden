using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cameraZoomController : MonoBehaviour
{

    private Camera cam;
    private float targetZoom;
    private float zoomFactor = 3f;
    private float zoomLerpSpeed = 10;
   private Animator animator;
    private int panelnumber;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
        animator = GetComponent<Animator>();
        //panelnumber = 1;

    }

    // Update is called once per frame
    void Update()
    {
        float scrollData;
        scrollData = Input.GetAxis("Mouse ScrollWheel");
        panelnumber = animator.GetInteger("Panel");

        targetZoom -= scrollData * zoomFactor;
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed);

        if (Input.GetMouseButtonDown(0))
        {
            panelnumber = panelnumber + 1;
            animator.SetInteger("Panel", panelnumber);

            if (panelnumber == 6)
            {
                Application.LoadLevel("SampleScene");
            }
        }
    }
   /* private void OnGUI()
    {
        if (Input.GetMouseButtonDown(0))
        {
            panelnumber = panelnumber + 1;
            animator.SetInteger("Panel", panelnumber);
            //Application.LoadLevel("SampleScene");
        }
    }*/
}
