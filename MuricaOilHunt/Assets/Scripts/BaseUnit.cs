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
    [Range(0, 100)] private int health;
    public int Health { get { return health; } }
    [SerializeField]
    [Range(0, 10)] private int Influence;
    [SerializeField]
    private RectTransform healthbar;
    protected Rigidbody2D RigidBody;
    public bool notDead = true;
    protected BaseUnit target;
    [SerializeField]
    protected BattleManager battleManager;

    [System.Serializable]
    public class ability
    {
        public string name;
        public int damage;
        public int abilityPoints;
        public GameObject attackerEffect;
        public GameObject targetEffect;
        [Range(0, 100)]
        public int baseAccuracy;
        AudioClip soundFX;
        Animator animator;

    }

    public IEnumerator Delay (float sec)
    {
        yield return new WaitForSeconds(sec);
    }
    
    [SerializeField]
    protected ability[] unit_abilitles;
    public ability[] Abilities { get { return unit_abilitles; } }
    [SerializeField]
    UnityEngine.UI.Text feedbackText;

    void Awake()
    {
        RigidBody = GetComponent<Rigidbody2D>();
    }//end Awake()

    void Update()
    {
        //healthbar.sizeDelta = new Vector2(health * 4.9f, 30.0f); // Draws the healthbar and sets the size 
    }


    protected virtual void Die()
    {
        //play death animation
        StartCoroutine(Delay(3));
        Destroy(gameObject);        
        
    }
    
    public virtual void TakeDamage(int damage, GameObject target)
    {
        //effect
        //feedbackText.text += "\n The " + target + " took " + damage + " damage";
        health -= damage;
        if(health <= 0 && notDead)
        {
            notDead = false;
            Die();            
        }
    }//end TakeDamage()
        
}//End BaseUnit()
