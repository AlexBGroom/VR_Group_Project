using System.Collections.Generic;
using UnityEngine;

public class MaintenancePanleController : MonoBehaviour
{
    [SerializeField] public List<MaintenancePanleButtonsController> storedButtons = new List<MaintenancePanleButtonsController>();
    [SerializeField] GameObject buttonsParent;
    [SerializeField] int minButtonsChanged;
    [SerializeField] int maxButtonsChanged;
    [SerializeField] public int activeButtons;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AssignButtons();
        InitalizePuzzle();
    }

    void AssignButtons()
    {
        int childCount = buttonsParent.transform.childCount;
        Debug.Log(childCount);

        for (int i = 0; i < childCount; i++)
        {
            MaintenancePanleButtonsController button = buttonsParent.transform.GetChild(i).GetComponent<MaintenancePanleButtonsController>(); 
            storedButtons.Add(button);
        }  
    }

    void InitalizePuzzle()
    {
        Debug.Log("Puzzle Initalized");
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
