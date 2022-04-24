using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThrown : MonoBehaviour
{
    float E_rotation = 30;

    bool E_Grabbed = false;
    public bool E_Thrown = false;                           // get rid of 'public' if other enemies start acting up.

    public GameObject EnemyBody_Idle;
    public GameObject EnemyBody_Grabbed;
    public GameObject EnemyBody_Thrown;
    public GameObject EnemyBody_LyingDown;

    public GameObject player;

    [SerializeField] Transform Player_Transform;



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

        transform.LookAt(Player_Transform);

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

