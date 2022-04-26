using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public float Health = 100f;
    public float Damage = 20;

    //

    public Image _healthBar;
    float CurrentHealth;
    float Maxhealth = 100f;                                                             //This will be the max health value the player can achieve
    //PlayerHealth _player;

 
    public void Start()                                                                 //Function to find the HealthBar Image and refernece the PlayerShip Script
    {
        _healthBar = GetComponent<Image>();
        //_player = FindObjectOfType<PlayerHealth>();
    }
    // Update is called once per frame
    void Update()                                                                   // This Function updates the image of the healthbar. The bright red bar will adjust itself
    {                                                                                //  according to the players health value
        CurrentHealth = this.Health;
        _healthBar.fillAmount = CurrentHealth / Maxhealth;
    }
    public void EnemyDamage()
    {
        Health = Health - Damage;

    }
}
