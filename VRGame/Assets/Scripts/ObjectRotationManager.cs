using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace Unity.VRTemplate
{
    public class ObjectRotationManager : MonoBehaviour
    {
        [SerializeField] XRKnob knob;
        public UnityEvent rotationComplete;

        public void CheckKnobRotation()
        {
            if (knob.value == 1)
            {
                rotationComplete.Invoke();
            }
        }
    }
}
