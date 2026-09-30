using UnityEngine;

[CreateAssetMenu(fileName = "MeleeWeaponBase", menuName = "Scriptable Objects/MeleeWeaponBase")]
public class MeleeWeaponBase : WeaponBase
{
    [SerializeField] public float attackRate;
    [SerializeField] public float swingMinimum;
}
