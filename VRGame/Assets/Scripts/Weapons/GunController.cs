using UnityEngine;
using UnityEngine.XR;
using System.Collections; 
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject firePoint;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] TrailRenderer trail;

    [SerializeField] GunBase gunStats;

    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(Shoot);
    }

    void Update()
    {
        //bool triggerValue;
        //if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out triggerValue) && triggerValue)
        //{
        //    Debug.Log("Trigger button is pressed.");
        //}
    }

    public void Shoot(ActivateEventArgs arg)
    {
        muzzleFlash.Play();

        Vector3 targetForward = firePoint.transform.forward;

        RaycastHit hit;

        if (Physics.Raycast(firePoint.transform.position, targetForward, out hit))
        {
            Debug.Log(hit.collider);

            TrailRenderer bulletTrail = Instantiate(trail, firePoint.transform.position, Quaternion.identity);
            StartCoroutine(SpawnTrail(bulletTrail, hit));

            if (hit.collider.TryGetComponent<Rigidbody>(out Rigidbody rb))
            {
                rb.AddForce(targetForward * gunStats.knockBackForce, ForceMode.Impulse);
            }

            if (hit.collider.TryGetComponent<IDamageable>(out IDamageable damageable))
            {
                damageable.TakeDamage(gunStats.damage);
            }
        }
    }

    private IEnumerator SpawnTrail(TrailRenderer shotTrail, RaycastHit hit)
    {
        float time = 0;
        Vector3 startPosition = shotTrail.transform.position;

        while (time < 1)
        {
            shotTrail.transform.position = Vector3.Lerp(startPosition, hit.point, time);
            time += Time.deltaTime / shotTrail.time;

            yield return null; 
        }

        shotTrail.transform.position = hit.point;

        Destroy(shotTrail.gameObject, shotTrail.time);
    }
}
