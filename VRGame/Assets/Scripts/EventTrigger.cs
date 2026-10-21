using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    public UnityEvent onTrigger;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<CharacterController>())
        {
            onTrigger.Invoke();

            Destroy(gameObject);
        }
    }
}
