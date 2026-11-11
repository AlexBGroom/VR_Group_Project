using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class WatchScannerController : MonoBehaviour, IScannable
{
    [SerializeField] UnityEvent scanEvent;
    [SerializeField] ParticleSystem positiveScanEffect;
    [SerializeField] ParticleSystem negativeScanEffect;

    [SerializeField] SecurityCardSO requiredCard;

    public void Scan(List<SecurityCardSO> cardList)
    {
        if (requiredCard == null)
        {
            scanEvent.Invoke(); 
            positiveScanEffect.Play();
            return;
        }

        if (cardList.Contains(requiredCard))
        {
            scanEvent.Invoke();
            positiveScanEffect.Play();
        } 
        else
        {
            negativeScanEffect.Play();
        }
    }
}
