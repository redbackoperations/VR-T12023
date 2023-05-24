using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityBikeController : MonoBehaviour
{

    public float movementSpeed = 5f;
    public float turnSpeed = 5f;

    private Rigidbody rb;
    private float turnForce;
    private float horizontalInput;

    public bool useGravity = true;

    #region Monobehaviour API

    private void Start()

    {

        rb = GetComponent<Rigidbody>();
        setForces();

    }

    void setForces()
    {
        turnForce = turnSpeed * rb.mass / 1000;
    }

    void FixedUpdate()

    {

        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        rb.velocity = movement * movementSpeed;

        //rb.useGravity = false;
        //if (useGravity) rb.AddForce(Physics.gravity * (rb.mass * rb.mass));

        // rb.AddForce(Physics.gravity * rb.mass);

        rb.AddTorque(horizontalInput * turnForce * transform.up);
        rb.AddForce(1, -700, 1);

    }

    #endregion
}
