using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Ch3_Kunoichi))]
public class Ch3_RayCast_Viewer : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = false;

        GUILayout.Label("RayCast Viewer");
        Ch3_Kunoichi kunoichi = target as Ch3_Kunoichi;
        GUILayout.TextField($"RayCast Length: {kunoichi.RayCastLength}");
    }
}
