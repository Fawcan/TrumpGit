using UnityEngine;
using System.Collections;

public class BattleManager : MonoBehaviour
{
    enum turn {player, enemy}

    [SerializeField]
    turn currentTurn;

    void Update()
    {
        if(currentTurn == turn.player)
        {
            

        }
        else
        {


        }
    }

}
