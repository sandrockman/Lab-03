using UnityEngine;
using System.Collections;
using UnityEditor;

public enum WeaponClassification
{
	TWO_HANDED,
	ONE_HANDED,
	OFF_HAND
}

public enum TypeWeapon
{
	SWORD,
	SHIELD,
	RELIC,
	HAMMER,
	SCYTHE
}

[System.Serializable]
public class WeaponTypes {

	public float damage;
	public bool isUpgradable;

	public WeaponClassification classification;
	public TypeWeapon typeWeapon;
}
