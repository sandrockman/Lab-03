using UnityEngine;
using System.Collections;
using UnityEditor;

public enum Faction
{
	AGGRESSIVE,
	NEUTRAL,
	PASSIVE
}

public enum AttackType
{
	MELEE,
	RANGED
}

public enum AttackDamage
{
	PHYSICAL,
	SPELL
}

public enum SpellType
{
	FIRE,
	FROST,
	ARCANE
}

public enum WeaponType
{
	TWO_HANDED,
	DUAL_WIELD
}

public enum ArmourType
{
	CLOTH,
	LEATHER,
	MAIL,
	PLATE
}

[System.Serializable]
public class EnemyTypes {
	public string name;

	public float health;
	public float mana;

	public Faction faction;
	public AttackType attackType;
	public AttackDamage attackDamage;
	public SpellType spellType;
	public WeaponType weaponType;
	public ArmourType armourType;
}
