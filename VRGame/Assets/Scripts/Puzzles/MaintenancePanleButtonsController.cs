using UnityEngine;
using System.Collections.Generic;

public class MaintenancePanleButtonsController : MonoBehaviour
{
    [SerializeField] public bool on;
    [SerializeField] MaintenancePanleController maintenancePanleController;

    public void TurnOn()
    {
        Debug.Log("Turned ON");
        GetComponent<Renderer>().material.color = Color.green;
        on = true;
        maintenancePanleController.activeButtons++;
    }

    public void TurnOff()
    {
        GetComponent<Renderer>().material.color = Color.red;
        on = false;
        maintenancePanleController.activeButtons--;
    }

    public void ToggleButton()
    {
        if(on == true)
        {
            TurnOn();
        }
        else
        {
            TurnOff();
        }
    }
}
