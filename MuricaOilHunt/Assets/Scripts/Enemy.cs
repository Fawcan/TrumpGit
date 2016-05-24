using UnityEngine;
using System.Collections;

public class Enemy : BaseUnit
{
    void Start()
    {

    }

    void Something()
    {

    }


    protected override void Die()
    {
        //player wins
        base.Die();
    }
}
