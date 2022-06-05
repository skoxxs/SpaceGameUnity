using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDestroyOnCollisionEnemy : RocketDestroyOnCollision
{
    [SerializeField] private GameObject explosion;

 
    private new void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion,transform.position, explosion.transform.rotation);
        base.OnCollisionEnter(collision);
    
    }
}
