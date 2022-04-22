using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThrown : MonoBehaviour
{
    float E_rotation = 30;

    bool E_isGrabbed = false;
    bool E_isThrown = false;

<<<<<<< HEAD
=======
<<<<<<< HEAD
    public GameObject player;

>>>>>>> main
    public GameObject EnemyBody_Idle;
    public GameObject EnemyBody_Grabbed;

    public GameObject player;


    private void Start()
    {

    }
    void FixedUpdate()
    {
        //IsGettingThrown();
    }


    void IsGettingGrabbed()
    {
        Debug.Log("Enemy is Grabbed");


        EnemyBody_Idle.SetActive(false);
        EnemyBody_Grabbed.SetActive(true);
<<<<<<< HEAD
=======
=======
    GameObject player;


    private void Start()
    {
        
    }
    void FixedUpdate()
    {
        //IsGettingThrown();
    }

   
    void IsGettingGrabbed()
    {
        Debug.Log("Enemy is Grabbed");
>>>>>>> main
    }
>>>>>>> main

        GameObject player;


         void Start()
        {

        }
        void FixedUpdate()
        {
            //IsGettingThrown();
        }


        void IsGettingGrabbed()
        {
            Debug.Log("Enemy is Grabbed");

        }

        void IsGettingThrown()
        {
            Debug.Log("Enemy is Thrown");

            /*

            transform.Rotate(new Vector3(E_rotation, 0.0f, 0.0f));

            if (transform.rotation.eulerAngles.z > 230)
            {
                transform.Rotate(0, 0, 0);
            }

            */


        }

        void ThrownToGround()
        {

        }

        void GettingUp()
        {

        }
    }
}

