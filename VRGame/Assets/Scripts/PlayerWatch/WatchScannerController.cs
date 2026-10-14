using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class WatchScannerController : MonoBehaviour, IScannable
{
    [SerializeField] UnityEvent scanEvent;

    [SerializeField] SecurityCardSO requiredCard;

    public void Scan(List<SecurityCardSO> cardList)
    {
        if (cardList.Contains(requiredCard))
        {
            scanEvent.Invoke();
        } 
        // else()
        // {
            
        // }
    }

    // IEnumerator ScanFail()
    // {
    //     //change an indicator to flash red
    // }
}
