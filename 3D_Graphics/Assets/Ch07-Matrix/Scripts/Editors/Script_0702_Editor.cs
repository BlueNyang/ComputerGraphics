using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Script_0702))]
public class Script_0702_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Script_0702 script = (Script_0702)target;
        if (GUILayout.Button("Do Matrix"))
        {
            PerformTransformation(script);
        }
    }

    private void PerformTransformation(Script_0702 script)
    {
        Vector3 _pos = script.targetPosition;
        Vector3 _rot = script.TargetEulerAngle;

        Quaternion _quat = Quaternion.Euler(_rot);

        Matrix4x4 matrix = Matrix4x4.TRS(_pos, _quat, Vector3.one);

        Matrix4x4 _mat = script.target.transform.localToWorldMatrix;
        _mat *= matrix;

        script.target.transform.SetPositionAndRotation(_mat.GetColumn(3), Quaternion.LookRotation(_mat.GetColumn(2), _mat.GetColumn(1)));
    }
}
