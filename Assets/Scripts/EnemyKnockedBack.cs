using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKnockedBack : MonoBehaviour
{
    //[SerializeField] GameObject enemy;

    EnemyThrown thrownState;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) //&& thrownState.E_Thrown == true
            Enemy_KnockedOff();
    }

    void Enemy_KnockedOff()
    {
        Debug.Log("2nd enemy has been knocked off feet!");
    }

}
