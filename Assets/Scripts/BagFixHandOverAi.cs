using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagFixHandOverAi : MonoBehaviour
{
    [SerializeField] private EnemyAI enemyAI;

    public void StartMove()
    {
        enemyAI.StartMove();
    }

    public void HandOverFramework(Framework framework)
    {
        enemyAI.SetFramework(framework);
    }


    public bool isLive()
    {
        return enemyAI.IsLive();
    }

    public bool isActiveToMove()
    {
        return enemyAI.isActiveToMove();
    }

}
