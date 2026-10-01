using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeleeWeaponController : MonoBehaviour
{
    [SerializeField] private MeleeWeaponBase _weaponStats;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private GameObject _weaponModel;
    [SerializeField] private List<IDamageable> recentlyHitObjects = new List<IDamageable>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Debug.Log(_rb.linearVelocity);

        // if(_rb.linearVelocity.magnitude >= _weaponStats.swingMinimum)
        // {
        //     _weaponModel.GetComponent<Renderer>().material.color = Color.red;
        // }
        // else
        // {
        //     _weaponModel.GetComponent<Renderer>().material.color = Color.green;
        // }
    }

    void OnTriggerEnter(Collider collider)
    {
        IDamageable damageObj = collider.GetComponent<IDamageable>();
        if(damageObj != null)
        {
            if(recentlyHitObjects.Contains(damageObj))
            {
                
            }
            else
            {
                recentlyHitObjects.Add(damageObj);
                damageObj.TakeDamage(_weaponStats.damage);
                StartCoroutine(targetReset(damageObj));
            }
        }
    }

    IEnumerator targetReset(IDamageable target)
    {
        yield return new WaitForSeconds(_weaponStats.attackRate);
        recentlyHitObjects.Remove(target);
    }
}
