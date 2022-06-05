using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIAddFire : EnemyAI
{
    [SerializeField] private GameObject rocket;
    [SerializeField] private GameObject pointSpavnRocket;
    [SerializeField] private float rocketSpeed = 500;

    [SerializeField] private float deltaTimeToFire = 10;

    private float timer = 0;

    protected new void Update()
    {
        base.Update();
        if (isActive)
        {

            timer += Time.deltaTime;
            if (timer > deltaTimeToFire)
            {
                timer = 0;
                fire();
            }
        }
    }





    private void fire()
    {
        GameObject _rocket = Instantiate(rocket, pointSpavnRocket.transform.position,rocket.transform.rotation);
        _rocket.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * -rocketSpeed);
    }

}
