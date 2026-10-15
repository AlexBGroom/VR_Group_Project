using UnityEngine;
using UnityEngine.Events;

public class DestroyableEntity : MonoBehaviour
{
    [SerializeField] UnityEvent onDestroy;
    [SerializeField] float health;

    [SerializeField] bool specificDamageType;
    [SerializeField] WeaponBase.WeaponTypes requieredWeaponType;

    public void TakeDamage(float damage, WeaponBase.WeaponTypes damageSource)
    {
        if (specificDamageType && damageSource == requieredWeaponType)
        {
            health -= damage;
        }
        else if (specificDamageType && damageSource != requieredWeaponType)
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
        }
        
    }
}
