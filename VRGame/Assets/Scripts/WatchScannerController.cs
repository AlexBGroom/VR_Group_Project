using UnityEngine;
using UnityEngine.Events;

public class WatchScannerController : MonoBehaviour, IScannable
{
    [SerializeField] UnityEvent scanEvent;

    public void Scan()
    {
        scanEvent.Invoke();
    }
}
