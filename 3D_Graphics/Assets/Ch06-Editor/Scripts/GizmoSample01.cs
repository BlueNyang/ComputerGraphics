using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoSample01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Callback to draw gizmos that are pickable and always drawn.
    /// </summary>
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 1.0f);

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, Vector3.one * 1);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, transform.position);

        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, Vector3.up * 3);
    }
}
