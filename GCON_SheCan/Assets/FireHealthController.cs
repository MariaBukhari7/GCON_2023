using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireHealthController : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;

    private float currentHealth;

 

    private MeshRenderer meshRenderer;

    private bool isDead;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        currentHealth = maxHealth;
       
        
    }

    public void ApplyDamage(float damage)
    {
        if (isDead) return;

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
            gameObject.SetActive(false);

          
        }

       
    }

    

   
}
