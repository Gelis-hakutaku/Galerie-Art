using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header ("Movement")]
    [SerializeField] private float moveSpeed;

    [SerializeField] private Transform orientation;

    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;

    [SerializeField] private Vector3 moveDirection;

    [SerializeField] private Rigidbody rb;

    public void Update()
    {
        Inputs();
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
}
