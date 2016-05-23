using UnityEngine;
using System.Collections;

/*
SCRIPT HANDLES BASE STRUCTURE FOR PLAYER AND ENEMY VALUES
CAN BE USED FOR INHERTIANCE OF CERTAIN BEAHVIOUR or CHANGE OF BEHAVIOUR
-- Created by David Halldin
*/


[RequireComponent(typeof(Rigidbody2D))]
public class BaseUnit : MonoBehaviour
{
    [SerializeField]
    [Range(0, 100)] private float mHealth;

    protected Rigidbody2D mRigidBody;
    public GameObject mPlayer;
    public GameObject mEnemy;

    void Awake()
    {
        mPlayer = GameObject.FindGameObjectWithTag("Player");
        mEnemy = GameObject.FindGameObjectWithTag("Enemy");
    } 

    void Start ()
    {
       	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(mHealth <= 0)
        {
            //insert value and action here
        }
	}
}
