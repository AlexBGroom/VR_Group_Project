using UnityEngine;

public class NewEnemyBase : MonoBehaviour, IDamageable
{


    [Header("Core Stats")]
    [SerializeField] protected float maxHealth = 100f;
    protected float currentHealth;

    [Header("Movement & combat stats")]
    [SerializeField] protected float moveSpeed = 2.0f;
    [SerializeField] protected float attackDamage = 10f;
    [SerializeField] protected float attackCooldown = 1.5f;

    [Header("Armour & resistance")]
    [Range(0f, 1f)]
    [SerializeField] protected float damageTakenMultiplier = 1.0f; // 1.0 will be the normal, and 0.5 will be 50% in armour reduction 

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    //this method will handle the incoming damage from a weapon
    public virtual void TakeDamage(float damage)
    {
        //Apply any armor or damage resistance if any
        float finalDamage = damage * damageTakenMultiplier;
        currentHealth -= finalDamage;

        Debug.Log($"{gameObject.name} took {finalDamage} damage. Remaining Health:{currentHealth}");

        if (currentHealth <= 0)
        {
            Death();
        }
    }
    
    protected virtual void Death()
    {
        Destroy(gameObject); 
    }
}
