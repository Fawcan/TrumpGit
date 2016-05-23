using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : BaseUnit
{
    GUIText[] actionButtons;

    //void Awake()
    //{
    //    for(int i = 0; i <actionButtons.Length; i++)
    //    {
    //        actionButtons[i].text = unit_abilitles[i].attackerEffect;
    //    }
    //}


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<BaseUnit>();

    }


    void PlayerClicking(int move)
    {

        Attack(unit_abilitles[move]);

    }

    protected override void Die()
    {
        //End game

        base.Die();
    }


}
