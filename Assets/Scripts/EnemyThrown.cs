using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThrown : MonoBehaviour
{
    float E_rotation = 30;

    bool E_Grabbed = false;
    public bool E_Thrown = false;                           // get rid of 'public' if other enemies start acting up.
    //public bool 

    public GameObject EnemyBody_Idle;
    public GameObject EnemyBody_Grabbed;
    public GameObject EnemyBody_Thrown;
    public GameObject EnemyBody_LyingDown;
    public GameObject EnemyBody_GettingUp;

    public GameObject player;

    [SerializeField] Transform Player_Transform;

    [SerializeField] AudioSource ImpactFloor_T_Source;
    [SerializeField] AudioClip ImpactFloor_T_Clip;



    private void Awake()
    {
        ImpactFloor_T_Source = GetComponent<AudioSource>();
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
                
                StartCoroutine(ThrownToGround());


       
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

    IEnumerator ThrownToGround()
    {
        E_Thrown = false;
        EnemyBody_Thrown.SetActive(false);
        EnemyBody_LyingDown.SetActive(true);

        ImpactFloor_T_Source.clip = ImpactFloor_T_Clip;
        ImpactFloor_T_Source.Play();

        yield return new WaitForSeconds(1);

        StartCoroutine(GettingUp());

    }

    IEnumerator GettingUp()
    { 

        EnemyBody_LyingDown.SetActive(false);
        EnemyBody_GettingUp.SetActive(true);


        yield return new WaitForSeconds(1);

        EnemyBody_GettingUp.SetActive(false);
        EnemyBody_Idle.SetActive(true);

    }
}

