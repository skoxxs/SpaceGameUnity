using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDestroy : MonoBehaviour
{
    [SerializeField] private float timeToDestroy = 10;

    private float curentTime = 0;

    void Update()
    {
        curentTime += Time.deltaTime;
        if (curentTime > timeToDestroy)
            Destroy(this.gameObject);
    }
}
