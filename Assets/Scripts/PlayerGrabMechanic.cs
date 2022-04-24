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
    public GameObject PlayerBody_Throwing;

    public Rigidbody playerRigidbody;

    public Transform GrabBox_Collider;

    RigidbodyConstraints originalConstraints;

    private void Awake()
    {
        originalConstraints = playerRigidbody.constraints;
    }
    void Start()
    {
        enemy = GameObject.FindWithTag("EnemyGrabBox");

        Collider collider = GrabBox_Collider.GetChild(0).GetComponent<Collider>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && P_isGrabbing == true)
        {
            StartCoroutine(ThrowingEnemy());
        }
    }

    void OnTriggerEnter(Collider other)                                                     ////////////////////////////////////////////////////////////////////////////////
    {

        if (other.CompareTag("EnemyGrabBox") && P_isGrabbing == false)

        if (enemy)

        GrabbingEnemy();
    }

    void GrabbingEnemy()
    {

        playerRigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotationX
                                      | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        

        P_isGrabbing = true;
        Debug.Log("Enemy has been grabbed!");
        PlayerBody_Idle.SetActive(false);
        PlayerBody_Grabbing.SetActive(true);

    }

    IEnumerator ThrowingEnemy()
    {
        P_isGrabbing = false;
        PlayerBody_Grabbing.SetActive(false);
        PlayerBody_Throwing.SetActive(true);

        yield return new WaitForSeconds(1);

        ThrowingRecovery();
    }

    void ThrowingRecovery()                                         // Player gets back up from throwing the enemy.
    {
        IdleStance();
    }

    void IdleStance()
    {

        Debug.Log("Player is back at idle stance");
        PlayerBody_Throwing.SetActive(false);
        PlayerBody_Idle.SetActive(true);
        playerRigidbody.constraints = originalConstraints;
    }

}
