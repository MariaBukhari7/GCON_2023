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


    private MeshRenderer meshRenderer;

    private bool isDead;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        currentHealth = maxHealth;
        canChangeFireIntinsity = true;
        
    }

    public void ApplyDamage(float damage)
    {
        if (isDead) return;

        currentHealth -= damage;

        if (currentHealth == 1500f)
        {
            canChangeFireIntinsity = false;
            ChangeIntinsity(10f);

        }else if (currentHealth == 1000f)
        {
            canChangeFireIntinsity = false;
            ChangeIntinsity(10f);
        }else if (currentHealth == 500f)
        {
            canChangeFireIntinsity = false;
            ChangeIntinsity(5f);
        }else if (currentHealth == 0f)
        {
            canChangeFireIntinsity = false;
            ChangeIntinsity(5f);
        }

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
            gameObject.SetActive(false);

          
        }
         
       
    }

    private void ChangeIntinsity( float rate)
    {
        var emisson = fireParticleSystem.emission;
        emisson.rateOverTime = intinsity - rate;
    }




}
