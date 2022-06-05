using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private GameObject explosion;
    [SerializeField] private float moveSpeedZ = 50.0f;
    [SerializeField] private float moveSpeedX = 50.0f;


    protected bool isActive = false;
    private EnemyAIControl enemyAIControl;
    private GameFild gameFild;
    private Rigidbody rbEnemy;
    private bool isLive = true;

    void Start()
    {
        rbEnemy = GetComponent<Rigidbody>();
        if (Random.Range(0, 2) == 1) moveSpeedX *= -1;
        enemyAIControl = GameObject.FindGameObjectWithTag("EnemyAIControl").GetComponent<EnemyAIControl>();
    }

    public void SetGameFild(GameFild _gameFild)
    {
        this.gameFild = _gameFild;
    }

    protected void Update()
    {
        if (isActive)
        {
            if (transform.position.x < gameFild.MinX)
                if (moveSpeedX < 0) moveSpeedX *= -1;

            if (transform.position.x > gameFild.MaxX)
                if (moveSpeedX > 0) moveSpeedX *= -1;

            if (transform.position.z < gameFild.MinZ)
            {
                if (Random.Range(0, 2) == 1)
                {
                    transform.position = gameFild.pointSpavn1.transform.position;
                }
                else
                {
                    transform.position = gameFild.pointSpavn2.transform.position;
                }
            }

            Vector3 offSet = new Vector3(moveSpeedX * Time.deltaTime, 0, -moveSpeedZ * Time.deltaTime);
            rbEnemy.MovePosition(rbEnemy.position + offSet);
        }
    }

    public void StartMove()
    {
        isActive = true;
    }

    public bool isActiveToMove()
    {
        return isActive;
    }

    public bool IsLive()
    {
        return isLive;
    }
 

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            moveSpeedX *= -1;
            return;
        }
        if (isLive)
        {
            enemyAIControl.UpdateOnEnemmyChange();
            Instantiate(explosion, this.transform.position, explosion.transform.rotation);
            isLive = false;
        }
        Destroy(this.gameObject);
    }
}
