using UnityEngine;

public class WatchCardScannerController : MonoBehaviour
{
    [SerializeField] PlayerWatchManager watchManager;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().TryGetComponent<SecurityCardPickup>(out SecurityCardPickup card))
        {
            watchManager.AddCard(card.securityCard);
        }
    }
}
