using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;   // Movement speed of the ball
    public float jumpForce = 7.0f;   // Jump force applied to the ball

    private Rigidbody rb;
    private bool isGrounded = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Check if the ball is on the ground
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);

        // Movement input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction based on input
        Vector3 movementDirection = (transform.forward * verticalInput + transform.right * horizontalInput).normalized;

        // Apply movement force to the ball
        Vector3 movement = movementDirection * moveSpeed * Time.deltaTime;
        rb.AddForce(movement, ForceMode.VelocityChange);

        // Jumping
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
