using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(WeaponController))]
public class WeaponControllerEditor : Editor {
	
	WeaponController controllerScript;
	
	void Awake()
	{
		controllerScript = (WeaponController)target;
	}
	
	public override void OnInspectorGUI()
	{
		serializedObject.Update ();
		
		SerializedProperty controller = serializedObject.FindProperty ("weaponObjects");
		
		EditorGUILayout.PropertyField (controller);
		
		if (controller.isExpanded) 
		{
			EditorGUILayout.PropertyField (controller.FindPropertyRelative ("Array.size"));
			EditorGUI.indentLevel++;
			for (int i = 0; i < controller.arraySize; i++) {
				EditorGUILayout.PropertyField (controller.GetArrayElementAtIndex (i));
			}
			EditorGUI.indentLevel--;
		}
		
		if (GUILayout.Button ("Print Weapon Array to Console")) 
		{
			controllerScript.PrintArray ();
		}
		serializedObject.ApplyModifiedProperties ();
	}
	
	
}