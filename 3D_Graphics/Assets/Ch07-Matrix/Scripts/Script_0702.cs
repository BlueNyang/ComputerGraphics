using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_0702 : MonoBehaviour
{
    public GameObject target;

    public Vector3 targetPosition;
    public Vector3 TargetEulerAngle;

    public Matrix4x4 matrixResult;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        if (target != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, target.transform.position);

        }
    }
}
