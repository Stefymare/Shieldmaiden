using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //Variables defined
    public CharacterController controller;

    [SerializeField] public float moveSpeed;
    [SerializeField] public float walkSpeed;
    [SerializeField] private float runSpeed;


    private void Update()
    {
        Move();
    }

    private void Move()
    {
        //Stores vertical and horizontal input 
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");

        //Stores the direction
        Vector3 moveDirection = new Vector3(hInput, 0f, vInput).normalized;


        if(moveDirection.magnitude >= 0.1f)
        {
            //Rotates the player
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            //Moves the player
            controller.Move(moveDirection * moveSpeed * Time.deltaTime);

            //Speeds the player
            if (moveDirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
            {
                Walk();
            }
            else if (moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
            {
                Run();
            }
        }
    }

    private void Walk()
    {
        moveSpeed = walkSpeed;
    }

    private void Run()
    {
        moveSpeed = runSpeed;

    }
}
