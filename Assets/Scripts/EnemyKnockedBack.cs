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

    [SerializeField] GameObject EnemyBody_Idle;
    [SerializeField] GameObject EnemyBody_KnockedBack;
    [SerializeField] GameObject EnemyBody_LyingDown;
    [SerializeField] GameObject EnemyBody_GettingUp;
    // [SerializeField] GameObject EnemyBody_Thrown;

    [SerializeField] AudioSource ImpactBody_Source;
    [SerializeField] AudioClip ImpactBody_Clip;

    [SerializeField] AudioSource ImpactFloor_K_Source;
    [SerializeField] AudioClip ImpactFloor_K_Clip;

  


    void Awake()
    {
        ImpactBody_Source = GetComponent<AudioSource>();
        ImpactFloor_K_Source = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter(Collider other)

        // Code that Knocks this enemy of their feet if the ther enemwas was Thrown into this Enemy
    {
        if (other.CompareTag("Enemy") && other.GetComponent<EnemyThrown>().E_Thrown == true
            && other.GetComponent<EnemyKnockedBack>().E_KnockedBack == false 
            && EnemySelf.GetComponent<EnemyKnockedBack>().E_KnockedBack == false) 
        {

            transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);

            EnemySelf.GetComponent<Rigidbody>().AddForce(other.transform.forward * KnockForce);

            Enemy_KnockedOff();
        }

        // Code the Knocks this enemy off their feet if the other enemy was Knocked Into this Enemy

        if (other.CompareTag("Enemy") && other.GetComponent<EnemyKnockedBack>().E_KnockedBack == true
                && other.GetComponent<EnemyThrown>().E_Thrown == false)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);

            EnemySelf.GetComponent<Rigidbody>().AddForce(-other.transform.forward * W_KnockForce);
            Enemy_KnockedOff();
        }


        // Code the lies this enemy onto the floor if they were knocked off

        if (other.CompareTag("Ground") && EnemySelf.GetComponent<EnemyKnockedBack>().E_KnockedBack == true)
        {
            StartCoroutine(Enemy_KnockedDown());
        }


    }

    //private 
        void Enemy_KnockedOff()
    {
        Debug.Log("2nd enemy has been knocked off feet!");
        
        E_KnockedBack = true;

        EnemyBody_Idle.SetActive(false);
        EnemyBody_KnockedBack.SetActive(true);

        ImpactBody_Source.clip = ImpactBody_Clip;
        ImpactBody_Source.Play();

    }
    
    IEnumerator Enemy_KnockedDown()
    {
        E_KnockedBack = false;
        EnemyBody_KnockedBack.SetActive(false);
        EnemyBody_LyingDown.SetActive(true);

        ImpactFloor_K_Source.clip = ImpactFloor_K_Clip;
        ImpactFloor_K_Source.Play();

        yield return new WaitForSeconds(1);

        StartCoroutine(Enemy_GettingUp());
    }

    IEnumerator Enemy_GettingUp()
    {
        EnemyBody_LyingDown.SetActive(false);
        EnemyBody_GettingUp.SetActive(true);


        yield return new WaitForSeconds(1);

        EnemyBody_GettingUp.SetActive(false);
        EnemyBody_Idle.SetActive(true);
    }

}
