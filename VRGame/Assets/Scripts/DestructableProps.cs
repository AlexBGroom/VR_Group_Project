using UnityEngine;

public class DestructableProps : MonoBehaviour, IDamageable
{
    [SerializeField] float health;
  

    public void TakeDamage(float damage, WeaponBase.WeaponTypes damageSource)
    {
        health -= damage;
        Debug.Log(health);

         if(health <= 0)
         {
            Destroy(gameObject);
        }
    } 
}
