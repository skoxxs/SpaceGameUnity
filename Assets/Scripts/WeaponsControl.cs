using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsControl : MonoBehaviour
{
    [SerializeField] private GameObject prefabRocket;

    [SerializeField] private GameObject[] pointSpawnRocket;
    [SerializeField] private float rocketSpeed = 100;
    [SerializeField] private float kdFire = 1;
    private float curentTimeToFire;

    // Start is called before the first frame update
    void Start()
    {
        curentTimeToFire = kdFire;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            fire();
        }

        curentTimeToFire += Time.deltaTime;
    }


    public void fire()
    {
        if (curentTimeToFire > kdFire)
        {
            GameObject rocket = Instantiate(prefabRocket, pointSpawnRocket[0].transform);
            rocket.GetComponent<Rigidbody>().AddForce(Vector3.forward * rocketSpeed);
            curentTimeToFire = 0;
        }
    }
}
