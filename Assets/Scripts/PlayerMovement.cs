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
       // print("The value is: " + Input.GetAxisRaw("Horizontal"));

        RotatePlayer();
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

    void RotatePlayer()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Euler(0f, rotation_Y, 0f);

        } else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0f, Mathf.Abs(rotation_Y), 0f);
        }
    }
}
