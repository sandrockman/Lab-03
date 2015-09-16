using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public EnemyTypes[] enemyObjects;

	public void PrintArray()
	{
		//*
		for (int i = 0;i < enemyObjects.Length; i++) 
		{
			Debug.Log("Name of enemy " + i + ": " + enemyObjects[i].name);
			Debug.Log("Health: " + enemyObjects[i].health);
			if(enemyObjects[i].mana != null)
				Debug.Log(" Mana: " + enemyObjects[i].mana);
			Debug.Log("Faction: " + enemyObjects[i].faction);
			if(enemyObjects[i].attackType != null)
				Debug.Log ("Attack Type: " + enemyObjects[i].attackType);
			if(enemyObjects[i].attackDamage != null)
				Debug.Log ("Attack Damage: " + enemyObjects[i].attackDamage);
			if(enemyObjects[i].spellType != null)
				Debug.Log ("Spell Type: " + enemyObjects[i].spellType);
			for(int j = 0; j < enemyObjects[i].weaponType.Length; j++)
			{
				Debug.Log ("Weapon Type " + j + ": " + enemyObjects[i].weaponType[j]);
			}
			for(int k = 0; k < enemyObjects[i].armourType.Length; k++)
			{
				Debug.Log ("Armour Type " + k + ": " + enemyObjects[i].armourType[k]);
			}
		}//*/
	}
}
