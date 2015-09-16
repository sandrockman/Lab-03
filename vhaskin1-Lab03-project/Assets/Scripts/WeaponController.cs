using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	public WeaponTypes[] weaponObjects;
	
	public void PrintArray()
	{
		//*
		for (int i = 0;i < weaponObjects.Length; i++) 
		{
			Debug.Log("damage of weapon " + i + ": " + weaponObjects[i].damage);
			Debug.Log("Classification: " + weaponObjects[i].classification);
			Debug.Log("Type of Weapon: " + weaponObjects[i].typeWeapon);
			Debug.Log("Is Upgradeable? " + weaponObjects[i].isUpgradable);
		}//*/
	}
}
