using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThrown : MonoBehaviour
{
    float E_rotation = 30;

    bool E_isGrabbed = false;
    bool E_isThrown = false;

    public GameObject player;

    public GameObject EnemyBody_Idle;
    public GameObject EnemyBody_Grabbed;

    PlayerGrabMechanic playerFunction;

    private void Start()
    {
        playerFunction = player.GetComponent<PlayerGrabMechanic>();

    }
    void Update()
    {
       
        if(playerFunction.P_isGrabbing == true)
        {
            IsGettingGrabbed();
        }


    }

   
    private void IsGettingGrabbed()
    {
        Debug.Log("Enemy is Grabbed");

        EnemyBody_Idle.SetActive(false);
        EnemyBody_Grabbed.SetActive(true);
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
