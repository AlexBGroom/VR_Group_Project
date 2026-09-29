using UnityEngine;

[CreateAssetMenu(fileName = "WeaponBase", menuName = "Scriptable Objects/WeaponBase")]
public class WeaponBase : ScriptableObject
{
    [SerializeField] public float damage;
    [SerializeField] public float knockBackForce;
}
