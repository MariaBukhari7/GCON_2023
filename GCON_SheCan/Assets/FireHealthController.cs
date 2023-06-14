using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireHealthController : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;
    private bool canChangeFireIntinsity;
    private float currentHealth;
    [SerializeField]
    private new ParticleSystem fireParticleSystem;
    private float intinsity = 30;
    [SerializeField] FireSystem fireSystem;



    private bool isDead;

    void Start()
    {
       
        currentHealth = maxHealth;
        canChangeFireIntinsity = true;
        
    }

    public void ApplyDamage(float damage)
    {
        if (isDead) return;

        currentHealth -= damage;

        

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
            fireSystem.AddToList();
            gameObject.SetActive(false);

          
        }
         
       
    }

    private void ChangeIntinsity( float rate)
    {
        var emisson = fireParticleSystem.emission;
        emisson.rateOverTime = intinsity - rate;
    }




}
