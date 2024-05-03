using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(HelloEditor))]
public class HelloEditorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.Label("Hello World");

        HelloEditor myScript = (HelloEditor)target;

        if(GUILayout.Button("Hello"))
        {
            Debug.Log("Hello");
        }

        if(GUILayout.Button("Get target String"))
        {
            Debug.Log(myScript.String);
        }
    }
}
