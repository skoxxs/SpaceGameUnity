using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketDestroyOnCollision : MonoBehaviour
{
   
    protected void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
