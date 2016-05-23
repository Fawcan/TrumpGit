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
    [Range(0, 100)] private int mHealth;
    [SerializeField]
    [Range(0, 10)] private int mInfluence;
    protected Rigidbody2D mRigidBody;
    public bool mNotDead = true;
    protected BaseUnit target;

    [System.Serializable]
    protected class ability
    {
        public string name;
        public int damage;
        public int abilityPoints;
        public GameObject attackerEffect;
        public GameObject targetEffect;
        [Range(0, 100)]
        public int baseAccuracy;
        AudioClip soundFX;

    }

    [SerializeField]
    protected ability[] unit_abilitles;

    void Awake()
    {
        mRigidBody = GetComponent<Rigidbody2D>();
    }//end Awake()


    protected virtual void Die()
    {
        //play death animation
    }
    
    public virtual void ApplyDamage(int mDamage, GameObject effect)
    {
        //effect

        mHealth -= mDamage;
        if(mHealth <= 0 && mNotDead)
        {
            mNotDead = false;
            Die();
        }
    }//end ApplyDamage()

    public virtual void GainInfluence()
    {

    }

    protected virtual void Attack(ability currentAbility)
    {
        // play effect on player    currentAbility.attackerEffect;

        target.ApplyDamage(currentAbility.damage, currentAbility.targetEffect);
    }
        
}//End BaseUnit()
