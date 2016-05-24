using UnityEngine;
using System.Collections;

public class Enemy : BaseUnit
{

	
    public void EnemyAttack()
    {
        Attack(unit_abilitles[Random.Range(0, unit_abilitles.Length)]);


    }
    /*
    public void StoltenBergAttack()
    {

        something 

    }


    public void PutinAttack()
    {


    }



    */

    protected override void Die()
    {
        //player wins
        base.Die();
    }
}
