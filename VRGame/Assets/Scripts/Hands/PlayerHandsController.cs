using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

public class PlayerHandsController : MonoBehaviour
{
    [Header("Animations")]
    [SerializeField]  Animator anim;

    [Header("XR Inputs")]
    [SerializeField]  XRInputValueReader<float> m_GripInput = new XRInputValueReader<float>("Grip");

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if(m_GripInput.ReadValue() >= 1)
        {
            anim.SetTrigger("Grip");
        }
        else
        {
            anim.SetTrigger("EndGrip");
        }
    }

}
