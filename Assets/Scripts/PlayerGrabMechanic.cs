using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrabMechanic : MonoBehaviour
{


    public bool P_isGrabbing = false;
    public bool P_isThrowing = false;

    GameObject enemy;

    public GameObject PlayerBody_Idle;
    public GameObject PlayerBody_Grabbing;

    public Rigidbody playerRigidbody;

    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)                                                     ////////////////////////////////////////////////////////////////////////////////
    {

        if (other.CompareTag("Enemy"))

        if (enemy)

        GrabbingEnemy();
    }

    void GrabbingEnemy()
    {

        playerRigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX
                                      ;


        P_isGrabbing = true;
        Debug.Log("Enemy has been grabbed!");
        PlayerBody_Idle.SetActive(false);
        PlayerBody_Grabbing.SetActive(true);

        Debug.Log("Enemy has been grabbed!");


        Debug.Log("Enemy has been grabbed!");
    }

}
