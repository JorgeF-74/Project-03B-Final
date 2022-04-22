using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrabMechanic : MonoBehaviour
{

<<<<<<< HEAD
    public bool P_isGrabbing = false;
    public bool P_isThrowing = false;

    GameObject enemy;

    public GameObject PlayerBody_Idle;
    public GameObject PlayerBody_Grabbing;

=======
    bool P_isGrabbing = false;
    bool P_isThrowing = false;

    GameObject enemy;

>>>>>>> main
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
<<<<<<< HEAD
        if (other.CompareTag("Enemy"))
=======
        if (enemy)
>>>>>>> main
        GrabbingEnemy();
    }

    void GrabbingEnemy()
    {
<<<<<<< HEAD
        P_isGrabbing = true;
        Debug.Log("Enemy has been grabbed!");
        PlayerBody_Idle.SetActive(false);
        PlayerBody_Grabbing.SetActive(true);
=======
        Debug.Log("Enemy has been grabbed!");
>>>>>>> main
    }

}
