using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

public class PlayerHandsController : MonoBehaviour
{
    [Header("Animations")]
    [SerializeField]  Animator anim;

    bool gripActive;

    [Header("XR Inputs")]
    [SerializeField]  XRInputValueReader<float> m_GripInput = new XRInputValueReader<float>("Grip");

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if(m_GripInput.ReadValue() >= 1 && gripActive != true)
        {
            Debug.Log("GripPressed");
            anim.SetTrigger("Grip");
            gripActive = true;
        }
        else if(m_GripInput.ReadValue() < 0.8 && gripActive == true)
        {
            anim.SetTrigger("EndGrip");
            Debug.Log("EndGrip");
            gripActive = false;
        }
    }

}
