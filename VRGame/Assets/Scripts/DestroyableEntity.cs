using UnityEngine;
using UnityEngine.Events;

public class DestroyableEntity : MonoBehaviour, IDamageable
{
    [SerializeField] UnityEvent onDestroy;
    [SerializeField] float health;
    public float Health
    {
        get => health;
        set
        {
            health -= value;

            if(health <= 0)
            {
                onDestroy.Invoke();
                takeDamageEffect.Play();
                Destroy(gameObject);
            }
        }
    }
    [SerializeField] ParticleSystem takeDamageEffect;

    [SerializeField] bool specificDamageType;
    [SerializeField] WeaponBase.WeaponTypes requieredWeaponType;

    public void TakeDamage(float damage, WeaponBase.WeaponTypes damageSource)
    {
        if (specificDamageType == true && damageSource == requieredWeaponType)
        {
            Health -= damage;
        }
        else if (specificDamageType == true && damageSource != requieredWeaponType)
        {
            return;
        }
        else
        {
            Health -= damage;
        }

        // if (health <= 0)
        // {
           
        // }
        
    }
}
