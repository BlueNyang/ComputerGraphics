using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Script_0703))]
public class Script_0703_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Script_0703 script = (Script_0703)target;

        if(GUILayout.Button("Create Grid")){
            script.CreateGridVertices(8, 8, 1f);
        }
    }
}
