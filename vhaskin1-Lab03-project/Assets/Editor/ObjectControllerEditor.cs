using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(ObjectController))]
public class ObjectControllerEditor : Editor {

	ObjectController controllerScript;

	void Awake()
	{
		controllerScript = (ObjectController)target;
	}

	public override void OnInspectorGUI()
	{
		serializedObject.Update ();

		serializedObject.ApplyModifiedProperties ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
