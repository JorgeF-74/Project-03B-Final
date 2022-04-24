using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowScriptTemp : MonoBehaviour
{
    /// <summary>
    ///                 ATTACH THIS SCRIPT TO THE ENEMY
    /// </summary>


    float throwForce = 500;
    Vector3 objectPos;
    float distance;

    public bool E_isGrabbed = false;    // this should not be copied into the EnemyThrown script, as the script already contains this bool
    
    public GameObject enemy; // if all enemies are effected by the Player Grab, maybe get rid of this reference

    public GameObject tempParent;

    public GameObject EnemyCollider;

    [SerializeField] GameObject player;

    [SerializeField] Transform E_ThrownPosition;
    [SerializeField] Transform E_CurrentPosition;


    void Start()
    {
       

    }

    
    void Update()
    {
        distance = Vector3.Distance(enemy.transform.position, tempParent.transform.position);
        if(distance >=2f)
        {
            E_isGrabbed = false;
        }


        if(E_isGrabbed == true)
        {
            enemy.GetComponent<Rigidbody>().velocity = Vector3.zero;
            enemy.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            enemy.transform.SetParent(tempParent.transform);

            
        }
            if (Input.GetKeyDown(KeyCode.J) && E_isGrabbed == true)
            {
                IsGettingThrown();
            }


            else
        {
            objectPos = enemy.transform.position;
            enemy.transform.SetParent(null);
            enemy.GetComponent<Rigidbody>().useGravity = true;
            enemy.transform.position = objectPos;
        }
    }

    void OnTriggerEnter(Collider other)                                                     ////////////////////////////////////////////////////////////////////////////////
    {

        if (other.CompareTag("GrabBox") && E_isGrabbed == false)

            IsGettingGrabbed();
    }

    void IsGettingGrabbed()
    {

        Debug.Log("Enemy has been grabbed");

        E_isGrabbed = true;
        enemy.GetComponent<Rigidbody>().useGravity = false;
        enemy.GetComponent<Rigidbody>().detectCollisions = true;

    }

    void IsGettingThrown()
    {

        // EnemyCollider.SetActive(false);

                                               //////reactivate to let go of enemy


        Debug.Log("Enemy has been thrown!");

        E_CurrentPosition.position = E_ThrownPosition.position;

        enemy.GetComponent<Rigidbody>().AddForce(-E_ThrownPosition.transform.forward * throwForce);

        E_isGrabbed = false;



        /*
        yield return new WaitForSeconds(1);

        EnemyCollider.SetActive(true);
        */

    }

}
