using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrabMechanic : MonoBehaviour
{

    bool P_isGrabbing = false;
    bool P_isThrowing = false;

    GameObject enemy;

    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (enemy)
        GrabbingEnemy();
    }

    void GrabbingEnemy()
    {
        Debug.Log("Enemy has been grabbed!");
    }

}
