using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrabMechanic : MonoBehaviour
{

<<<<<<< HEAD

=======
<<<<<<< HEAD
>>>>>>> main
    public bool P_isGrabbing = false;
    public bool P_isThrowing = false;

    GameObject enemy;

    public GameObject PlayerBody_Idle;
    public GameObject PlayerBody_Grabbing;

<<<<<<< HEAD

=======
=======
    bool P_isGrabbing = false;
    bool P_isThrowing = false;

    GameObject enemy;

>>>>>>> main
>>>>>>> main
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)                                                     ////////////////////////////////////////////////////////////////////////////////
    {
<<<<<<< HEAD

        if (other.CompareTag("Enemy"))

        if (enemy)

=======
<<<<<<< HEAD
        if (other.CompareTag("Enemy"))
=======
        if (enemy)
>>>>>>> main
>>>>>>> main
        GrabbingEnemy();
    }

    void GrabbingEnemy()
    {
<<<<<<< HEAD

=======
<<<<<<< HEAD
>>>>>>> main
        P_isGrabbing = true;
        Debug.Log("Enemy has been grabbed!");
        PlayerBody_Idle.SetActive(false);
        PlayerBody_Grabbing.SetActive(true);
<<<<<<< HEAD

        Debug.Log("Enemy has been grabbed!");


        Debug.Log("Enemy has been grabbed!");
=======
=======
        Debug.Log("Enemy has been grabbed!");
>>>>>>> main
>>>>>>> main
    }

}
