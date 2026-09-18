using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    [SerializeField] GameObject obj;

    public void ChangeColour()
    {
        obj.GetComponent<Renderer>().material.color = Color.red;
    }
}
