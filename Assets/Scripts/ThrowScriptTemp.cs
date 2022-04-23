using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowScriptTemp : MonoBehaviour
{
    /// <summary>
    ///                 ATTACH THIS SCRIPT TO THE ENEMY
    /// </summary>


    float throwForce = 600;
    Vector3 objectPos;
    float distance;

    public bool E_isGrabbed = false;    // this should not be copied into the EnemyThrown script, as the script already contains this bool
    
    public GameObject enemy; // if all enemies are effected by the Player Grab, maybe get rid of this reference

    public GameObject tempParent;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(E_isGrabbed == true)
        {
            enemy.GetComponent<Rigidbody>().velocity = Vector3.zero;
            enemy.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            enemy.transform.SetParent(tempParent.transform);

            if(Input.GetButtonDown("J"))
            {
                //throw
            }
        }

        else
        {
            objectPos = enemy.transform.position;
            enemy.transform.SetParent(null);
            enemy.GetComponent<Rigidbody>().useGravity = true;
            //enemy.transform.position = objectPos;
        }
    }

    void OnTriggerEnter(Collider other)                                                     ////////////////////////////////////////////////////////////////////////////////
    {

        if (other.CompareTag("GrabBox"))

            IsGettingGrabbed();
    }

    void IsGettingGrabbed()
    {
        E_isGrabbed = true;
        enemy.GetComponent<Rigidbody>().useGravity = false;
        enemy.GetComponent<Rigidbody>().detectCollisions = true;

    }

}
