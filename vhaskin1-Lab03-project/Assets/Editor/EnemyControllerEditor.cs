using UnityEngine;
using System.Collections;
using UnityEditor;
	
[CustomEditor(typeof(EnemyController))]
public class EnemyControllerEditor : Editor {
		
	EnemyController controllerScript;

	void Awake()
	{
		controllerScript = (EnemyController)target;
	}
		
	public override void OnInspectorGUI()
	{
		serializedObject.Update ();
			
		SerializedProperty controller = serializedObject.FindProperty ("enemyObjects");

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
		serializedObject.ApplyModifiedProperties ();
	}
		
}