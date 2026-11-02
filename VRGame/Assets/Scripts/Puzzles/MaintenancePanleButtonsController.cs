using UnityEngine;

public class MaintenancePanleButtonsController : MonoBehaviour
{
    [SerializeField] public bool on;

    public void TurnOn()
    {
        GetComponent<Renderer>().material.color = Color.green;
        on = true;
    }

    public void TurnOff()
    {
        GetComponent<Renderer>().material.color = Color.red;
        on = false;
    }
}
