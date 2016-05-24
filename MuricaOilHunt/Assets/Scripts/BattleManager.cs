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
        }


    }

    public void AttackIsDone()
    {
        attackIsDone = true;
    }

    public void PlayerClicking(int type)
    {
        GameObject attacker;
        GameObject defender;

        if (currentTurn ==  turn.player)
        {
            attacker = GameObject.FindGameObjectWithTag("Player");
            defender = GameObject.FindGameObjectWithTag("Enemy");
        }
        else
        {
            attacker = GameObject.FindGameObjectWithTag("Enemy"); 
            defender = GameObject.FindGameObjectWithTag("Player");
        }


        Debug.Log("Clicked one of the buttons");

        Attack(attacker.GetComponent<BaseUnit>().Abilities[type], defender.GetComponent<BaseUnit>());
        
    }//end PlayerClicking()

    private void Attack(BaseUnit.ability ability, BaseUnit defender)
    {
        Debug.Log("Using: " + ability.name);
        Debug.Log("Attack " + ability.name + " inflicted " + ability.damage);
        defender.TakeDamage(ability.damage, ability.targetEffect);        
    }





}
