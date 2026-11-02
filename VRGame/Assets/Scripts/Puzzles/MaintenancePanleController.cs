using System.Collections.Generic;
using UnityEngine;

public class MaintenancePanleController : MonoBehaviour
{
    [SerializeField] List<MaintenancePanleButtonsController> storedButtons = new List<MaintenancePanleButtonsController>();

    [SerializeField] int minButtonsChanged;
    [SerializeField] int maxButtonsChanged;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void InitalizePuzzle()
    {
        int buttonsTotal = Random.Range(minButtonsChanged, maxButtonsChanged);

        for (int i = 0; i < buttonsTotal;) 
        { 
            int num = Random.Range(0, storedButtons.Count);

            if (storedButtons[num].on != true)
            {
                storedButtons[num].TurnOn();
                i++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
