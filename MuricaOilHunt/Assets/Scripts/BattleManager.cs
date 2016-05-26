using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/*
Script handles the events of battle and checks whos turn it is.
- created by David Halldin

*/
//[RequireComponent(typeof(UIHandler))]

public class BattleManager : MonoBehaviour
{
    enum turn {player, enemy}
    [SerializeField]
    turn currentTurn;
    [SerializeField]
    public UIHandler message;
    
    bool isClicked = false;
    //bool isDead = false;
    
    
    IEnumerator AttackPhase(int type)
    {
        
        Attack(GameObject.FindGameObjectWithTag("Player").GetComponent<BaseUnit>().Abilities[type],
            GameObject.FindGameObjectWithTag("Enemy").GetComponent<BaseUnit>());
        message.Print(" Crump made an attack ");
        yield return new WaitForSeconds(1);
        

        Attack(GameObject.FindGameObjectWithTag("Enemy").GetComponent<BaseUnit>().Abilities[(int)Random.Range(0, 4)],
            GameObject.FindGameObjectWithTag("Player").GetComponent<BaseUnit>());

    }

    public void UseAbility(int type)
    {
        if (isClicked == false)
        {
            StartCoroutine(AttackPhase(type));
            Debug.Log("Clicked one of the buttons");
            Debug.Log("Enemy performed random attack");
            isClicked = true;
        }

        

    }//end UseAbility()

    private void Attack(BaseUnit.ability ability, BaseUnit defender)
    {
        GameObject defenderHealth;
        Debug.Log("Using: " + ability.name);
        Debug.Log("Attack " + ability.name + " inflicted " + ability.damage);
        defender.TakeDamage(ability.damage, ability.targetEffect);        
        Debug.Log("En testlinje!");

        if(currentTurn == turn.player)
        {           
            defenderHealth = GameObject.FindGameObjectWithTag("EnemyHealth");
            defenderHealth.GetComponent<UnityEngine.UI.Image>().fillAmount = (float)defender.Health / (float)100;
            Debug.Log("Health is : " + defender.Health);
            currentTurn = turn.enemy;;
            Debug.Log("Player Attack was made: ");
                        
        }

        else
        {
            defenderHealth = GameObject.FindGameObjectWithTag("PlayerHealth");
            defenderHealth.GetComponent<UnityEngine.UI.Image>().fillAmount = (float)defender.Health / (float)100;
            currentTurn = turn.player;
            Debug.Log("Enemy Attack Was made");
            isClicked = false;            
        }                 
          
              
    }





}
