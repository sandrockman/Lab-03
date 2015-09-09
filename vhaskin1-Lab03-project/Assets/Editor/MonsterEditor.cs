using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Monster))]
public class MonsterEditor : Editor {

	Monster monsterScript;
	bool visibleRange = false;
	bool transitionRange = false;
	bool spawnTypes = false;

	void Awake()
	{
		monsterScript = (Monster)target;
	}

	public override void OnInspectorGUI()
	{
		//Display a foldout, with the default value stored in visibleRange & the label "Visibility Settings"
		//As the foldout is manipulated, save changes into visibleRange
		visibleRange = EditorGUILayout.Foldout (visibleRange, "Visibility Settings");
		if (visibleRange) 
		{
			//Increase the indent level by one
			EditorGUI.indentLevel++;
			//the variable VariableVisibletime on the monsterScript should equal the setting the user picked for the toggle
			//the toggle should display the variable VariableVisibleTime
			monsterScript.VariableVisibleTime = EditorGUILayout.Toggle("Vaviable Visible Time?",
			                                                           monsterScript.VariableVisibleTime);
			if(monsterScript.VariableVisibleTime)
			{
				EditorGUILayout.LabelField("Maximum - Minimum Time");
				EditorGUILayout.BeginHorizontal();
				//Since I manually created the label above, I am using an overload of the float field so 
				//no default label is displayed immediately before it.
				monsterScript.VisibleTimeMax = EditorGUILayout.FloatField(monsterScript.VisibleTimeMax);
				monsterScript.VisibleTimeMin = EditorGUILayout.FloatField(monsterScript.VisibleTimeMin);
				EditorGUILayout.EndHorizontal();
			}
			else
			{
				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.PrefixLabel("VisibleTime:");
				//Again, I manually created a prefix label to display so I am overloading the float field so no
				//default label is shown
				monsterScript.VisibleTimeMax = EditorGUILayout.FloatField (monsterScript.VisibleTimeMax);
				EditorGUILayout.EndHorizontal();
			}
			//Reduce the indent level by one
			EditorGUI.indentLevel--;
		}
		EditorGUILayout.Space ();

		//same foldout, but for transitionRange
		transitionRange = EditorGUILayout.Foldout (transitionRange, "Transition Settings");
		if (transitionRange) 
		{
			//Increase the indent level by one
			EditorGUI.indentLevel++;
			//The variable VariableTransitionTime on the monsterScript should equal 
			//the setting the user picked for the toggle
			//The toggle should display the variable Variable Transition Time
			monsterScript.VariableTransitionTime = EditorGUILayout.Toggle("Variable Transition Time?",
			                                                              monsterScript.VariableTransitionTime);
			if (monsterScript.VariableTransitionTime)
			{
				EditorGUILayout.LabelField("Maximum - Minimum Time");
				EditorGUILayout.BeginHorizontal();
				//Since I manually created the label above, I am using an overload 
				//of the Float Field so no default label is displayed immediately before it
				monsterScript.TransitionTimeMax = EditorGUILayout.FloatField(monsterScript.TransitionTimeMax);
				monsterScript.TransitionTimeMin = EditorGUILayout.FloatField(monsterScript.TransitionTimeMin);
				EditorGUILayout.EndHorizontal();
			}
			else
			{
				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.PrefixLabel("Transition Time:");
				//Again, I manually created a prifix label to display so I am 
				//overloading the float field so no default label is shown
				monsterScript.TransitionTimeMax = EditorGUILayout.FloatField(monsterScript.TransitionTimeMax);
				EditorGUILayout.EndHorizontal();
			}

			//Reduce the indent level by one
			EditorGUI.indentLevel--;

		}
		EditorGUILayout.Space ();

		//same foldout, but for spawnTypes
		spawnTypes = EditorGUILayout.Foldout (spawnTypes, "Spawn Settings");
		if (spawnTypes) 
		{
			//Increase the indent level by one
			EditorGUI.indentLevel++;

			//Sync the object with the script
			serializedObject.Update();

			//Show the array field
			EditorGUILayout.PropertyField(serializedObject.FindProperty("possibleTypes"), true);

			//Reduce the indent level by one
			EditorGUI.indentLevel--;
		}
		EditorGUILayout.Space ();

		//display the point value
		monsterScript.PointWorth = EditorGUILayout.IntField ("Point Worth: ", monsterScript.PointWorth);

		//Apply all changes to the object
		serializedObject.ApplyModifiedProperties ();
	}




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
