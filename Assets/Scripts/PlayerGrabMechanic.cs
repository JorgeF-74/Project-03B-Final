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

    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        GrabbingEnemy();
    }

    void GrabbingEnemy()
    {
        P_isGrabbing = true;
        Debug.Log("Enemy has been grabbed!");
        PlayerBody_Idle.SetActive(false);
        PlayerBody_Grabbing.SetActive(true);
    }

}
