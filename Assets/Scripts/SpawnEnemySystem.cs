using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemySystem : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabEnemy;

    [SerializeField] private int numX;
    [SerializeField] private int numY;
    [SerializeField] private float spaseX;
    [SerializeField] private float spaseY;
    [SerializeField] private Quaternion rotSpawn;
    [SerializeField] private GameFild gameFild;

    private Vector3 startPoint;
    private GameObject[,] massEnemy;
    void Start()
    {
        massEnemy = new GameObject[numX,numY];
        startPoint = this.transform.position;
        for (int i = 0; i < numX; i++)
            for (int j = 0; j < numY; j++)
            {
                massEnemy[i,j] = (GameObject)Instantiate(prefabEnemy[Random.Range(0, prefabEnemy.Length)],startPoint + new Vector3( i*spaseX, 0, j*spaseY),rotSpawn);
                massEnemy[i, j].GetComponent<EnemyAI>().SetGameFild(gameFild);
            }
    }

    public GameObject[,] GetMassEnemy()
    {
        return massEnemy;
    }
   
}
