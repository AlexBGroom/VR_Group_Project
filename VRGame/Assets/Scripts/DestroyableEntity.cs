using UnityEngine;
using UnityEngine.Events;

public class DestroyableEntity : MonoBehaviour, IDamageable
{
    [SerializeField] UnityEvent onDestroy;
    [SerializeField] float health;

    [SerializeField] bool specificDamageType;
    [SerializeField] WeaponBase.WeaponTypes requieredWeaponType;

    public void TakeDamage(float damage, WeaponBase.WeaponTypes damageSource)
    {
        if (specificDamageType == true && damageSource == requieredWeaponType)
        {
            health -= damage;
        }
        else if (specificDamageType == true && damageSource != requieredWeaponType)
        {
            return;
        }
        else
        {
            health -= damage;
        }

        if (health <= 0)
        {
            onDestroy.Invoke();
            Destroy(gameObject);
        }
        
    }
}
