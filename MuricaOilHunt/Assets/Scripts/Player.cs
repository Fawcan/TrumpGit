using UnityEngine;
using System.Collections;

public class Player : BaseUnit
{
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
