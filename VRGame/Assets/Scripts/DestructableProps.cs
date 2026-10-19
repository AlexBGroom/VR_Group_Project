using UnityEngine;

public class DestructableProps : MonoBehaviour, IDamageable
{
    [SerializeField] float health;
  

    public void TakeDamage(float damage, WeaponBase.WeaponTypes damageSource)
    {
        health -= damage;

         if(health <= 0)
         {
            Destroy(gameObject);
        }
    } 
}
