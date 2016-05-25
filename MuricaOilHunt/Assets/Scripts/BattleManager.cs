using UnityEngine;
using System.Collections;
/*
Script handles the events of battle and checks whos turn it is.
- created by David Halldin

*/
public class BattleManager : MonoBehaviour
{
    enum turn {player, enemy}
    [SerializeField]
    turn currentTurn;

    bool attackIsDone = false;

    [SerializeField]
    Enemy enemy;

    [SerializeField]
    private int enemyAttack; 

    

    public void AttackIsDone()
    {
        attackIsDone = true;
       
    }

    public void UseAbility(int type)
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

        GameObject defenderHealth;

        Debug.Log("Nadsdsdsd");

        if(currentTurn == turn.player)
        {
            
            
            defenderHealth = GameObject.FindGameObjectWithTag("EnemyHealth");
            defenderHealth.GetComponent<UnityEngine.UI.Image>().fillAmount = (float)defender.Health / (float)100;
            Debug.Log("Health is : " + defender.Health);
            //currentTurn = turn.enemy;
            AttackIsDone();
            Debug.Log("Player Attack was made: ");
            UseAbility(enemy.GetAttackInput());
             
            
        }
        else
        {
            
            defenderHealth = GameObject.FindGameObjectWithTag("PlayerHealth");
            defenderHealth.GetComponent<UnityEngine.UI.Image>().fillAmount = (float)defender.Health / (float)100;
            
            //currentTurn = turn.player;
            AttackIsDone();
            Debug.Log("Enemy Attack Was made"); 
        } 
                 
          
              
    }





}
