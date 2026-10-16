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
            Debug.Log("Watch does have correct card");
            scanEvent.Invoke();
        } 
        else
        {
           Debug.Log("Watch does not have the correct card"); 
        }
    }

    // IEnumerator ScanFail()
    // {
    //     //change an indicator to flash red
    // }
}
