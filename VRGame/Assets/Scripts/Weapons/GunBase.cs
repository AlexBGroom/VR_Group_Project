using UnityEngine;

[CreateAssetMenu(fileName = "GunBase", menuName = "Scriptable Objects/GunBase")]
public class GunBase : WeaponBase
{
    [SerializeField] float fierRate;
    [SerializeField] int magSize;
}
