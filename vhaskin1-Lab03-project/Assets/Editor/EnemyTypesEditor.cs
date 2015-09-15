using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomPropertyDrawer(typeof(EnemyTypes))]
public class EnemyTypesEditor : PropertyDrawer {

	float extraHeight = 102f;

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{

		EditorGUI.BeginProperty (position, label, property);
		
		SerializedProperty name = property.FindPropertyRelative ("name");
		
		SerializedProperty health = property.FindPropertyRelative ("health");
		SerializedProperty mana = property.FindPropertyRelative ("mana");

		SerializedProperty faction = property.FindPropertyRelative ("faction");
		SerializedProperty attackType = property.FindPropertyRelative ("attackType");
		SerializedProperty attackDamage = property.FindPropertyRelative ("attackDamage");

		SerializedProperty spellType = property.FindPropertyRelative ("spellType");
		SerializedProperty weaponType = property.FindPropertyRelative ("weaponType");
		
		SerializedProperty armourType = property.FindPropertyRelative ("armourType");

		float offsetVar = position.x;
		
		Rect nameDisplay = new Rect(position.x, position.y, 60f, 17f);
		EditorGUI.LabelField (nameDisplay, "Name:");
		Rect objectNameDisplay = new Rect (position.x + 50, position.y, position.width - 50f, 15f);
		EditorGUI.PropertyField (objectNameDisplay, name, GUIContent.none);

		//next line
		Rect healthNameRect = new Rect (offsetVar, position.y + 17, 60f, 17f);
		offsetVar += 50f;
		EditorGUI.LabelField (healthNameRect, "Health:");

		Rect healthRect = new Rect (offsetVar, position.y + 17, position.width / 4, 17f);
		offsetVar += position.width / 4;
		EditorGUI.PropertyField (healthRect, health, GUIContent.none);

		Rect manaNameRect = new Rect (offsetVar, position.y + 17, 55f, 17f);
		offsetVar += 45f;
		EditorGUI.LabelField (manaNameRect, "Mana:");

		Rect manaRect = new Rect (offsetVar, position.y + 17, position.width / 4, 17f);
		offsetVar = position.x;
		EditorGUI.PropertyField (manaRect, mana, GUIContent.none);

		//next line
		Rect factionDataRect = new Rect (offsetVar, position.y + 34, 70f, 17f);
		offsetVar += 60f;
		EditorGUI.LabelField (factionDataRect, "Faction:");

		Rect factionRect = new Rect (offsetVar, position.y + 34, position.width / 3, 17f);
		offsetVar += (position.width / 3) - 10;
		EditorGUI.PropertyField (factionRect, faction, GUIContent.none);

		Rect atkTypeDataRect = new Rect (offsetVar, position.y + 34, 75f, 17f);
		offsetVar += 65f;
		EditorGUI.LabelField (atkTypeDataRect, "Atk Type:");

		Rect atkTypeRect = new Rect (offsetVar, position.y + 34, position.width / 3, 17f);
		offsetVar = position.x;
		EditorGUI.PropertyField (atkTypeRect, attackType, GUIContent.none);

		//next line
		Rect atkDmgDataRect = new Rect (offsetVar, position.y + 51, 100f, 17f);
		offsetVar += 90f;
		EditorGUI.LabelField (atkDmgDataRect, "Atk Dmg Type:");
		
		Rect atkDmgRect = new Rect (offsetVar, position.y + 51, position.width / 3, 17f);
		offsetVar = position.x;
		EditorGUI.PropertyField (atkDmgRect, attackDamage, GUIContent.none);

		//Debug.Log (objectType.enumValueIndex);
		/*
		switch ((ObjectType)objectType.enumValueIndex) 
		{
		case ObjectType.BREAKABLE:

			break;
		case ObjectType.DAMAGING:

			break;
		case ObjectType.HEALING:

			break;
		case ObjectType.PASSABLE:

			break;
		case ObjectType.SOLID:
			break;
		default:
			Debug.Log("EnemyTypeDrawer switch goof. A-hyuck.");
			break;
		}
		//*/
		EditorGUI.EndProperty ();
	}


	public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
		return base.GetPropertyHeight (property, label) + extraHeight;
	}

}
