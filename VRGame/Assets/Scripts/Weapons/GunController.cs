using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject firePoint;
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
        RaycastHit hit;

        if (Physics.Raycast(firePoint.transform.position, Vector3.forward, out hit))
        {
            Debug.Log(hit.collider);
        }
    }
}
