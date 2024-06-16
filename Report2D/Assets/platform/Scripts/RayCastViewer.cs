
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Kunoichi))]
public class RayCastViewer : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = false;

        GUILayout.Label("RayCast Viewer");
        Kunoichi kunoichi = target as Kunoichi;
        GUILayout.TextField($"RayCast Length: {kunoichi.RayCastLength}");
    }
}

