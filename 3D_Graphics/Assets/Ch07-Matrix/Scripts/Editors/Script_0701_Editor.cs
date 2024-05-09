using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Script_0701))]
public class Script_0701_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Script_0701 script = (Script_0701)target;

        if (GUILayout.Button("Do Matrix"))
        {
            script.matrixOut = script.transform.localToWorldMatrix;

            Vector3 rightV = script.matrixOut.GetColumn(0);
            Vector3 upV = script.matrixOut.GetColumn(1);
            Vector3 frontV = script.matrixOut.GetColumn(2);
            Vector3 position = script.matrixOut.GetColumn(3);

            Debug.Log($@"-----------Matrix-----------");
            Debug.Log($@"   Right: {rightV}");
            Debug.Log($@"   Up: {upV}");
            Debug.Log($@"   Front: {frontV}");
            Debug.Log($@"   Position: {position}");
        }
    }
}
