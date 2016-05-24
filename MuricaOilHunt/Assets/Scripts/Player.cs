using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : BaseUnit
{


    void Awake()
    {

    }


    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<BaseUnit>();

    }

    protected override void Die()
    {
        //End game

        base.Die();
    }


}
