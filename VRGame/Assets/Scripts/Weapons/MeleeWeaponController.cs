using UnityEngine;

public class MeleeWeaponController : MonoBehaviour
{
    [SerializeField] private MeleeWeaponBase _weaponStats;
    [SerializeField] private Rigidbody _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(_rb.linearVelocity);

        if(_rb.linearVelocity.magnitude >= _weaponStats.swingMinimum)
        {
            
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        IDamageable damageObj = collider.GetComponent<IDamageable>();
        if(damageObj != null)
        {
            damageObj.TakeDamage(_weaponStats.damage);
        }
    }
}
