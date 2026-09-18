using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    public UnityEvent onPress;

    void OnTriggerEnter(Collider collider)
    {
        onPress.Invoke();
    }
}
