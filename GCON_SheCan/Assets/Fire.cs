using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //public ParticleSystem part;

    

    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Fire"))
            Destroy(other);
    }
}
