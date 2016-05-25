using UnityEngine;
using System.Collections;

public class Enemy : BaseUnit
{

    
    void Start()
    {

    }

    

    
    
    protected override void Die()
    {
        //player wins
        base.Die();
    }
}
