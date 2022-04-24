using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThrown : MonoBehaviour
{
    float E_rotation = 30;

    bool E_Grabbed = false;
    bool E_Thrown = false;

    public GameObject EnemyBody_Idle;
    public GameObject EnemyBody_Grabbed;
    public GameObject EnemyBody_Thrown;
    public GameObject EnemyBody_LyingDown;

    public GameObject player;
    



    private void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && E_Grabbed == true)
            IsGettingThrown();


        //IsGettingThrown();
    }

    void OnTriggerEnter(Collider other)                                                     ////////////////////////////////////////////////////////////////////////////////
    {

        if (other.CompareTag("GrabBox"))

                IsGettingGrabbed();

        if (other.CompareTag("Ground") && E_Thrown == true)
                
                ThrownToGround();

    }

    void IsGettingGrabbed()
    {
       // Debug.Log("Enemy is Grabbed");

        E_Grabbed = true;

        EnemyBody_Idle.SetActive(false);
        EnemyBody_Grabbed.SetActive(true);

    }

    void IsGettingThrown()
    {
       // Debug.Log("Enemy is Thrown");
       
        

        E_Grabbed = false;
        E_Thrown = true;

        EnemyBody_Grabbed.SetActive(false);
        EnemyBody_Thrown.SetActive(true);

        
    }

    void ThrownToGround()
    {
        EnemyBody_Thrown.SetActive(false);
        EnemyBody_LyingDown.SetActive(true);
    }

    void GettingUp()
    {

    }
}

