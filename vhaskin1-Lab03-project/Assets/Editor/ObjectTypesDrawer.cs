using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomPropertyDrawer(typeof(ObjectTypes))]
public class ObjectTypesDrawer : PropertyDrawer {

	ObjectTypes thisObject;

	float extraHeight = 55f;

	int shouldSolidMove = 0;

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		Rect objectTypeDisplay = new Rect (position.x, position.y, position.width, 15f);

		EditorGUI.BeginProperty (position, label, property);

		SerializedProperty objectType = property.FindPropertyRelative ("type");

		SerializedProperty breakablePoints = property.FindPropertyRelative ("breakablePoints");

		SerializedProperty solidMoving = property.FindPropertyRelative ("solidMoving");
		SerializedProperty solidStart = property.FindPropertyRelative ("solidStart");
		SerializedProperty solidEnd = property.FindPropertyRelative ("solidEnd");

		SerializedProperty damageType = property.FindPropertyRelative ("damageType");
		SerializedProperty damageAmount = property.FindPropertyRelative ("damageAmount");

		SerializedProperty healingType = property.FindPropertyRelative ("healingType");
		SerializedProperty healingPickupType = property.FindPropertyRelative ("healingPickupType");
		SerializedProperty healingAmount = property.FindPropertyRelative ("healingAmount");

		EditorGUI.PropertyField (objectTypeDisplay, objectType, GUIContent.none);

		Debug.Log (objectType.enumValueIndex);

		switch ((ObjectType)objectType.enumValueIndex) 
		{
		case ObjectType.BREAKABLE:
			Rect breakableRect = new Rect(position.x, position.y + 17, position.width, 15f);
			EditorGUI.PropertyField (breakableRect, breakablePoints);
			break;
		case ObjectType.DAMAGING:
			float offset = position.x;

			Rect damageTypeLabelRect = new Rect(offset, position.y + 17, 55f, 17f);
			offset += 45;
			EditorGUI.LabelField(damageTypeLabelRect, "Type");

			Rect damageTypeRect = new Rect(offset, position.y + 17, position.width /3, 17f);
			offset += position.width / 3;
			EditorGUI.PropertyField(damageTypeRect, damageType, GUIContent.none);

			Rect damageAmountLabelRect = new Rect(offset, position.y + 17, 65f, 17f);
			offset += 55;
			EditorGUI.LabelField (damageAmountLabelRect, "Amount");

			Rect damageAmountRect = new Rect(offset, position.y + 17, position.width / 3, 17f);
			EditorGUI.PropertyField(damageAmountRect, damageAmount, GUIContent.none);

			break;
		case ObjectType.HEALING:
			Rect healingRect = new Rect(position.x, position.y + 17, position.width, 17f);
			EditorGUI.LabelField (healingRect, "There are not settings for a passable object.");

			break;
		case ObjectType.PASSABLE:
			Rect passRect = new Rect(position.x, position.y + 17, position.width, 17f);
			EditorGUI.LabelField (passRect, "There are not settings for a passable object.");
			break;
		case ObjectType.SOLID:
			Rect shouldMove = new Rect(position.x, position.y + 17, position.width, 17f);
			int index = solidMoving.boolValue ? 0 : 1;
			string[] options = new string[] {"Yes", "No"};
			index = EditorGUI.Popup(shouldMove, "Should it move?", index, options);
			solidMoving.boolValue = (index > 0) ? false : true;
			//*
			if (solidMoving.boolValue)
			{
				float offsetS = position.x;
				Rect startRect = new Rect(offsetS, position.y + 34, position.width / 2, 17f);
				offsetS += position.width / 2;
				EditorGUI.LabelField(startRect, "Start Point");

				startRect = new Rect(offsetS, position.y + 34, position.width / 2, 17f);
				offsetS += position.width / 2;
				EditorGUI.LabelField(startRect, "End Point");

				offsetS = position.x;
				startRect = new Rect(offsetS, position.y + 51, position.width / 2, 17f);
				offsetS += position.width / 2;
				EditorGUI.PropertyField(startRect, solidStart, GUIContent.none);

				startRect = new Rect(offsetS, position.y + 51, position.width / 2, 17f);
				offsetS += position.width / 2;
				EditorGUI.PropertyField(startRect, solidEnd, GUIContent.none);
			}
			//*/
			break;
		default:
			Debug.Log("ObjectTypeDrawer switch goof. A-hyuck.");
			break;
		}

		EditorGUI.EndProperty ();
	}

	public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
		return base.GetPropertyHeight (property, label) + extraHeight;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
