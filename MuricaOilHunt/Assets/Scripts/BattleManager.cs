using UnityEngine;
using System.Collections;

public class BattleManager : MonoBehaviour
{
    enum turn {player, enemy}
    [SerializeField]
    turn currentTurn;

    bool attackIsDone = false;

    [SerializeField]
    Enemy enemy;

    void Update()
    {
        if(currentTurn == turn.player)
        {
            if(attackIsDone)
            {
                currentTurn = turn.enemy;
                attackIsDone = false;
            }

        }
        else
        {
            attackIsDone = false;
            currentTurn = turn.player;
            enemy.EnemyAttack();
        }


    }

    public void AttackIsDone()
    {
        attackIsDone = true;
    }





}
