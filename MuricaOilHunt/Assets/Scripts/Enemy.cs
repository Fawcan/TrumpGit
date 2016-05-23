using UnityEngine;
using System.Collections;

public class Enemy : BaseUnit
{

	
    void EnemyAttack()
    {
        Attack(unit_abilitles[Random.Range(0, unit_abilitles.Length)]);


    }

    protected override void Die()
    {
        //player wins
        base.Die();
    }
}
