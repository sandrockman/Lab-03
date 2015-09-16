using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomPropertyDrawer(typeof(WeaponTypes))]
public class WeaponTypesEditor : PropertyDrawer {

	float extraHeight = 55f;
	
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		
		EditorGUI.BeginProperty (position, label, property);

		SerializedProperty classification = property.FindPropertyRelative ("classification");
		SerializedProperty typeWeapon = property.FindPropertyRelative ("typeWeapon");

		SerializedProperty damage = property.FindPropertyRelative ("damage");
		
		SerializedProperty isUpgradable = property.FindPropertyRelative ("isUpgradable");
		
		float offsetVar = position.x;
		
		Rect nameDisplay = new Rect(position.x, position.y, 100f, 17f);
		offsetVar += 100f;
		EditorGUI.LabelField (nameDisplay, "Weapon Class:");
		Rect classDisplay = new Rect (offsetVar, position.y, position.width - offsetVar, 15f);
		offsetVar = position.x;
		EditorGUI.PropertyField (classDisplay, classification, GUIContent.none);
		
		//next line
		Rect typeNameRect = new Rect (offsetVar, position.y + 17, 100f, 17f);
		offsetVar += 100f;
		EditorGUI.LabelField (typeNameRect, "Weapon Type:");
		
		Rect typeRect = new Rect (offsetVar, position.y + 17, position.width - offsetVar, 17f);
		offsetVar = position.x;
		EditorGUI.PropertyField (typeRect, typeWeapon, GUIContent.none);

		//next line
		Rect dmgNameRect = new Rect (offsetVar, position.y + 34, 70f, 17f);
		offsetVar += 60f;
		EditorGUI.LabelField (dmgNameRect, "Damage:");
		
		Rect dmgRect = new Rect (offsetVar, position.y + 34, 70f, 17f);
		offsetVar += 60f;
		EditorGUI.PropertyField (dmgRect, damage, GUIContent.none);

		//*
		if ((TypeWeapon)typeWeapon.enumValueIndex != TypeWeapon.HAMMER) 
		{
			Rect upRect = new Rect (offsetVar, position.y + 34, 110f, 17f);

			isUpgradable.boolValue = EditorGUI.Toggle (upRect, "Upgradable?", isUpgradable.boolValue);
		}
		offsetVar = position.x;

		EditorGUI.EndProperty ();
	}
	
	
	public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
		return base.GetPropertyHeight (property, label) + extraHeight;
	}
	
}