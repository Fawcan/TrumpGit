using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    Enemy enemy;
    Player player;
    [SerializeField]
    private string enemyName;
    bool isClicked = false;
    public bool canAttack = true;
    //public Sprite trumpIdle;
    //public Sprite trumpAttacking;
    //public Sprite trumpJibberish;    
    
    IEnumerator AttackPhase(int type)
    {
        bool Continue = true;

        Continue = Attack(GameObject.FindGameObjectWithTag("Player").GetComponent<BaseUnit>().Abilities[type],
            GameObject.FindGameObjectWithTag("Enemy").GetComponent<BaseUnit>());

        yield return new WaitForSeconds(1);        

        if (Continue)
        {
            Attack(GameObject.FindGameObjectWithTag("Enemy").GetComponent<BaseUnit>().Abilities[(int)Random.Range(0, 4)],
            GameObject.FindGameObjectWithTag("Player").GetComponent<BaseUnit>());
            canAttack = true;
        }

    }

    IEnumerator PlayClip()
    {
        yield return new WaitForSeconds(2);
    }

    IEnumerator HandleDeath(BaseUnit defender)
    {
        defender.Die();
        yield return new WaitForSeconds(1);
        int i = Application.loadedLevel;
        Application.LoadLevel(i + 1);
        /*SceneManager.LoadScene("WorldMapCanadaBeaten");*/// insert what scene player should return to! for eg WorldMapCanadaBeaten        
        //PlayClip();
        //((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
    }

    public void UseAbility(int type)
    {
        if (isClicked == false)
        {
            StartCoroutine(AttackPhase(type));
            //Debug.Log("Clicked one of the buttons");
            //Debug.Log("Enemy performed random attack");
            isClicked = true;
        }

        

    }//end UseAbility()

    private bool Attack(BaseUnit.ability ability, BaseUnit defender)
    {
        GameObject defenderHealth;
        
       // Debug.Log("Using: " + ability.name);
        //Debug.Log("Attack " + ability.name + " inflicted " + ability.damage);
        defender.TakeDamage(ability.damage, ability.targetEffect);
        //Debug.Log("En testlinje!");

        if(currentTurn == turn.player)
        {           
            defenderHealth = GameObject.FindGameObjectWithTag("EnemyHealth");
            defenderHealth.GetComponent<UnityEngine.UI.Image>().fillAmount = (float)defender.Health / (float)100;
            message.Print(" Conrad Crump " + "used " + ability.abilityName + " dealing: " + ability.damage + " damage");

            //Debug.Log("Player Attack was made: ");
            if (defender.Health <= 0)
            {
                StartCoroutine(HandleDeath(defender));
                return false;
            }
            else
            {
                currentTurn = turn.enemy;
                return true;
            }

        }

        else
        {

            defenderHealth = GameObject.FindGameObjectWithTag("PlayerHealth");
            defenderHealth.GetComponent<UnityEngine.UI.Image>().fillAmount = (float)defender.Health / (float)100;
            message.Print(enemyName + " used " + ability.abilityName + " dealing: " + ability.damage + " damage");
            currentTurn = turn.player;
            Debug.Log("Enemy Attack Was made");
            isClicked = false;
            canAttack = false;
            if (defender.Health <= 0)
            {
                defender.Die();
                return false;
            }
            else
                return true;

        }  
                         
          
              
    }





}
