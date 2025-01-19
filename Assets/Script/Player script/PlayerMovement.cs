using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header ("Movement")]
    [SerializeField] private float moveSpeed;

    [SerializeField] private float groundDrag;

    [Header("Ground Check")]
    [SerializeField] private float playerHeigh;
    [SerializeField] private LayerMask whatIsGround;
    private bool grounded;

    [SerializeField] private Transform orientation;

    private float horizontalInput;
    private float verticalInput;

    private Vector3 moveDirection;

    [SerializeField] private Rigidbody rb;

    public void Update()
    {
        /*
        //ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeigh * 0.5f + 0.2f, whatIsGround);
        */

        Inputs();
        SpeedControl();

        /*
        //handle drag
        if (grounded) 
            rb.drag = groundDrag;
        else
            rb.drag = 0;
        */
    }

    public void FixedUpdate()
    {
        MovePlayer();
    }

    private void Inputs()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        //calculate move direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        
        rb.AddForce(moveDirection.normalized *  moveSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        //clamp speed if the player is too fast
        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitVel.x, rb.velocity.y, limitVel.z);
        }
    }
}
