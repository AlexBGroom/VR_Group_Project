using UnityEngine;

public class SecurityCardPickup : MonoBehaviour
{
    [SerializeField] GameObject cardObject;
    [SerializeField] public SecurityCardSO securityCard;

    void Awake()
    {
        cardObject.GetComponent<Renderer>().material = securityCard.setMaterial;
    }
}
