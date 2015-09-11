﻿using UnityEngine;
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
