using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnockedBack : MonoBehaviour
{
    //[SerializeField] GameObject enemy;

    EnemyThrown thrownState;

    float KnockForce = 300f;
    float W_KnockForce = 250f;

    public bool E_KnockedBack = false;

    [SerializeField] GameObject EnemySelf;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && other.GetComponent<EnemyThrown>().E_Thrown == true) 
        {

            transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);

            EnemySelf.GetComponent<Rigidbody>().AddForce(other.transform.forward * KnockForce);
            Enemy_KnockedOff();
        }

        if (other.CompareTag("Enemy") && other.GetComponent<EnemyKnockedBack>().E_KnockedBack == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);

            EnemySelf.GetComponent<Rigidbody>().AddForce(-other.transform.forward * W_KnockForce);
            Enemy_KnockedOff();
        }


    }

    void Enemy_KnockedOff()
    {
        Debug.Log("2nd enemy has been knocked off feet!");
        E_KnockedBack = true;
        
    }

}
