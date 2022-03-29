using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //Variables defined
    public CharacterController controller;

    public Transform cam;

    [SerializeField] public float moveSpeed;
    [SerializeField] public float walkSpeed;
    [SerializeField] private float runSpeed;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    [SerializeField] public float gravity;
    // [SerializeField] private float jumpForce;//

     public Transform groundCheck;

     public LayerMask groundLayer;

    public float jumpForce = 20;

    public float velocity;




    private void Update()
    {
        Move();

        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity = jumpForce;
        }   

        velocity += gravity * Time.deltaTime;

        controller.Move(new Vector3(0, velocity, 0) * Time.deltaTime);
        
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
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            //Moves the player
           moveDir.y += gravity * Time.deltaTime;

            /*
            bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.15f, groundLayer);
          //  moveDir.y += gravity * Time.deltaTime;
            if (isGrounded)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    moveDir.y = jumpForce;
                }
            }*/

            controller.Move(moveDir.normalized * moveSpeed * Time.deltaTime);
            

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
