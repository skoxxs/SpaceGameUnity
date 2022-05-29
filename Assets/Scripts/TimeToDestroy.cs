using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDestroy : MonoBehaviour
{
    [SerializeField] private float timeToDestroy = 10;

    private float curentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (curentTime > timeToDestroy)
            Destroy(this.gameObject);
        curentTime += Time.deltaTime;
    }
}
