using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody myBody;

    public float walk_Speed = 3f;
    public float z_Speed = 3f;

    private float rotation_Y = -90f;
    private float rotation_Speed = 15f;
    void Awake()
    {
        myBody = GetComponent<Rigidbody>();

    }

    void Update()
    {
        print("The value is: " + Input.GetAxisRaw("Horizontal"));
    }

    private void FixedUpdate()
    {
        DetectMovement();
    }

    void DetectMovement()
    {
        myBody.velocity = new Vector3(
            Input.GetAxisRaw("Horizontal") * (-walk_Speed),
            myBody.velocity.y, 
            Input.GetAxisRaw("Vertical") * (-z_Speed));
    }
}
