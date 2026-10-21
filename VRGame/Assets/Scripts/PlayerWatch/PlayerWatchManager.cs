using UnityEngine;
using System.Collections.Generic;

public class PlayerWatchManager : MonoBehaviour
{
    [SerializeField] GameObject scannerPoint;
    [SerializeField] GameObject cardInstert;
    [SerializeField] GameObject watchScreen;
    [SerializeField] float rayRange;
    [SerializeField]List<SecurityCardSO> storedCards = new List<SecurityCardSO>();
    [SerializeField]List<PlayerWatchScreensSO> storedScreens = new List<PlayerWatchScreensSO>();
    [SerializeField] PlayerWatchScreensSO selectedWatchScreen;
    [SerializeField] GameObject activeWatchScreen;
    [SerializeField] GameObject screenPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void ActivateWatchScreen()
    {
        activeWatchScreen = Instantiate(selectedWatchScreen.watchScreen, screenPosition.transform.position, screenPosition.transform.rotation);

    }

    void DeactivateWatchScreen()
    {
        Destroy(activeWatchScreen);
    }

    void ChangeWatchScreen()
    {
        DeactivateWatchScreen();

        
    }

    // Update is called once per frame
    void Update()
    {
        ScannerCheck();
    }

    private void ScannerCheck()
    {
        RaycastHit hit;
        
        if(Physics.Raycast(scannerPoint.transform.position, scannerPoint.transform.forward, out hit, rayRange))
        {
            if (hit.collider.TryGetComponent<IScannable>(out IScannable scannable))
            {
                scannable.Scan(storedCards);
            }
            else
            {
            
            }
        }
    }

    private void EnableScanner()
    {
        
    }

    public void AddCard(SecurityCardSO card)
    {
        storedCards.Add(card);
    }

    private void ChangeScreen()
    {
        
    }

    public void AddScreen(PlayerWatchScreensSO screen)
    {
        
    }

    
}
