using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCanon : MonoBehaviour
{
    [SerializeField]
    private new ParticleSystem particleSystem;

    [SerializeField]
    private float damage;

    [SerializeField]
    private float fireRate;

    private List<ParticleCollisionEvent> collisionEvents;

    private string fireTag;

    private bool fireCooldown;

    void Start()
    {
        particleSystem.Stop();
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    void OnParticleCollision(GameObject other)
    {
        ParticlePhysicsExtensions.GetCollisionEvents(particleSystem, other, collisionEvents);

        for (int i = 0; i < collisionEvents.Count; i++)
        {
            var collider = collisionEvents[i].colliderComponent;
            if (collider.CompareTag(fireTag))
            {
                var health = collider.GetComponent<FireHealthController>();
              health.ApplyDamage(damage);
            }
        }
    }

    public void Fire()
    {

       
        particleSystem.Play();


    }

    public void StopFire()
    {


        particleSystem.Stop();


    }


    public void SetEnemyTag(string fireTag)
    {
        this.fireTag = fireTag;
    }
}
