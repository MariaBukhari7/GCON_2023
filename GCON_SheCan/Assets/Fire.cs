using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    private new ParticleSystem fireParticleSystem;
    private float intinsity = 30;


   private void ChangeIntinsity()
    {
        var emisson = fireParticleSystem.emission;
        emisson.rateOverTime = intinsity - 10;
    }
}
