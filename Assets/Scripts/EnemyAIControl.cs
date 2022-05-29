using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIControl : MonoBehaviour
{
    [SerializeField] private SpawnEnemySystem _spawnEnemySystem;

    private GameObject[,] massEnemy;


    private int enemyLength;
    // Start is called before the first frame update
    void Start()
    {
        massEnemy = _spawnEnemySystem.GetMassEnemy();
        enemyLength = massEnemy.GetLength(0) * massEnemy.GetLength(1);
    }

    // Update is called once per frame
    public void UpdateOnEnemmyChange()
    {
      
        enemyLength--;
        //Debug.Log("boom");
        if (enemyLength == 0)
        {
            //Debug.Log("win");
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().GameWin();
        }

        FindToActiveEnemy();
    }

    private void FindToActiveEnemy()
    {
        bool exit_for = false;
        for (int i = 0; i < massEnemy.GetLength(1); i++)
        {
            int random = Random.Range(0, massEnemy.GetLength(0));

            for (int j = 0; j < massEnemy.GetLength(0); j++)
            {
                int f = j + random;
                if (f >= massEnemy.GetLength(0)) f -= massEnemy.GetLength(0);
                if (massEnemy[f, i] != null )
                {
                    if (!massEnemy[f, i].GetComponent<BagFixHandOverAi>().isActiveToMove()) {
                        massEnemy[f, i].GetComponent<BagFixHandOverAi>().StartMove();
                        exit_for = true;
                    }
                }
                if (exit_for) break;
            }
            if (exit_for) break;
        }

        
    }

}
