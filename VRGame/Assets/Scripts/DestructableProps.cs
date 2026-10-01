using UnityEngine;

public class DestructableProps : MonoBehaviour, IDamageable
{
    [SerializeField] float health;
  

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(health);

         if(health <= 0)
         {
            Destroy(gameObject);
        }
    } 
}
