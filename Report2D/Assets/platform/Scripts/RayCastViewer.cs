
using UnityEditor;

[CustomEditor(typeof(Kunoichi))]
public class RayCastViewer : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUI.BeginDisabledGroup(true);
        Kunoichi kunoichi = (Kunoichi)target;
        EditorGUILayout.LabelField("Raycast Viewer");
        EditorGUILayout.FloatField("Distance From Ground", kunoichi.distanceFromGround);
    }
}
