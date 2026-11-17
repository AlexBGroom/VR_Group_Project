using UnityEngine;
using UnityEngine.Events;

public class DestroyableEntity : MonoBehaviour, IDamageable
{
    [SerializeField] UnityEvent onDestroy;
    [SerializeField] float health;
    
    [SerializeField] ParticleSystem takeDamageEffect;
    [SerializeField] GameObject destroyEffect;

    [SerializeField] bool specificDamageType;
    [SerializeField] WeaponBase.WeaponTypes requieredWeaponType;

    public void TakeDamage(float damage, WeaponBase.WeaponTypes damageSource)
    {
        if (specificDamageType == true && damageSource == requieredWeaponType)
        {
            health -= damage;
            if (takeDamageEffect == null)
            {
               takeDamageEffect.Play(); 
            }
        }
        else if (specificDamageType == true && damageSource != requieredWeaponType)
        {
            return;
        }
        else
        {
            health -= damage;
            if (takeDamageEffect == null)
            {
               takeDamageEffect.Play(); 
            }
        }

        if (health <= 0)
        {
            onDestroy.Invoke();
            if (destroyEffect == null)
            {
                GameObject eff = Instantiate(destroyEffect, transform.position, Quaternion.identity);
                Destroy (eff, 1f);
            }
            
            Destroy(gameObject);
        }
        
    }
}
