using UnityEngine;
using System.Collections;

public class Enemy : BaseUnit
{
    [SerializeField]
    GameObject HealthBar;
    
    void Start()
    {
        HealthBar = GameObject.FindGameObjectWithTag("EnemyHealth");
    }

    
    
    protected override void Die()
    {
        //player wins
        base.Die();
    }

    public int GetAttackInput ()
    {
        int type = Random.Range(0, Abilities.Length);

        return type;
    }


}
