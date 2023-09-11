using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Move : MonoBehaviour
{
    public float xForce = 1.0f;
    public float zForce = 1.0f;
    public float yForce = 1.0f;
    public float jumpCooldown = 1.0f; // Cooldown time for jumping (in seconds)
    public float groundCheckRadius = 1f; // Radius of the spherecast for ground detection
    public LayerMask groundLayer; // Layer mask for ground objects

    private float lastJumpTime;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastJumpTime = -jumpCooldown; // Set the initial time to allow jumping
    }

    void Update()
    {
        // Movement input
        float x = 0.0f;
        float z = 0.0f;
        float y = 0.0f;

        if (Input.GetKey(KeyCode.W))
        {
            x = x - xForce;
        }

        if (Input.GetKey(KeyCode.S))
        {
            x = x + xForce;
        }

        if (Input.GetKey(KeyCode.A))
        {
            z = z - zForce;
        }

        if (Input.GetKey(KeyCode.D))
        {
            z = z + zForce;
        }

        // Jumping
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space) && Time.time - lastJumpTime >= jumpCooldown)
        {
            y = yForce;
            lastJumpTime = Time.time;
        }

        GetComponent<Rigidbody>().AddForce(x, y, z);
    }

    bool IsGrounded()
    {
        // Perform a spherecast downward to check if the player is grounded
        return Physics.SphereCast(transform.position, groundCheckRadius, Vector3.down, out _, 0.1f, groundLayer);
    }
}
