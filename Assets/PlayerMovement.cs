using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public int jumpingForce = 30; // needs some work

    // Start is called before the first frame update
    //void Start()
    //{
    //    //Debug.Log("Hello, World");
    //    //rb.useGravity = true; rb.velocity = Vector3.zero;
    //    rb.AddForce(0, 200, 500); // x, y, z
    //}

    // Update is called once per frame
    void FixedUpdate() // Using FixedUpdate for calculatinig physics
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        }
        if (Input.GetKey("q"))
        {
            rb.AddForce(0, jumpingForce * Time.deltaTime, 0);
        }
    }
}
