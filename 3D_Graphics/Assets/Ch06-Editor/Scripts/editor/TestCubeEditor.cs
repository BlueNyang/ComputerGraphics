using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TestCube))]
public class TestCubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();


        TestCube myScript = (TestCube)target;

        myScript.baseSize = EditorGUILayout.Slider("baseSize", myScript.baseSize, 0.0f, 10.0f);
    }
}
