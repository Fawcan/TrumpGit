using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : BaseUnit
{

    public override void Die()
    {
        base.Die();
        SceneManager.LoadScene("TrumpBeat");
    }
}