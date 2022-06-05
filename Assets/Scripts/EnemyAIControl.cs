using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIControl : MonoBehaviour
{
    [SerializeField] private SpawnEnemySystem _spawnEnemySystem;

    private GameObject[,] massEnemy;


    private int enemyLength;
    void Start()
    {
        massEnemy = _spawnEnemySystem.GetMassEnemy();
        enemyLength = massEnemy.GetLength(0) * massEnemy.GetLength(1);
    }

    public void UpdateOnEnemmyChange()
    {
      
        enemyLength--;
        if (enemyLength == 0)
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().GameWin();
        }

        FindToActiveEnemy();
    }

    private void FindToActiveEnemy()
    {
        for (int i = 0; i < massEnemy.GetLength(1); i++)
        {
            int random = Random.Range(0, massEnemy.GetLength(0));

            for (int j = 0; j < massEnemy.GetLength(0); j++)
            {
                int f = j + random;
                if (f >= massEnemy.GetLength(0)) f -= massEnemy.GetLength(0);
                if (massEnemy[f, i] != null )
                {
                    if (!massEnemy[f, i].GetComponent<EnemyAI>().isActiveToMove()) {
                        massEnemy[f, i].GetComponent<EnemyAI>().StartMove();
                        return;
                    }
                }
            }
        }

        
    }

}
