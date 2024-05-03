using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoSample02 : MonoBehaviour
{
    public Mesh mesh;
    public Color lineColor = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos(){
        if(mesh == null){
            MeshFilter meshFilter = GetComponent<MeshFilter>();
            if(meshFilter != null){
                mesh = meshFilter.sharedMesh;
            }
        }
        if(mesh != null){
            Gizmos.color = lineColor;
            DrawWireFrame();
        }
    }

    void DrawWireFrame(){
        GL.PushMatrix();
        GL.MultMatrix(transform.localToWorldMatrix);
        Gizmos.color = lineColor;

        for(int i = 0; i < mesh.subMeshCount; i++){
            int[] triangles = mesh.GetTriangles(i);
            for(int j = 0; j < triangles.Length; j += 3){
                Gizmos.DrawLine(mesh.vertices[triangles[j]], mesh.vertices[triangles[j + 1]]);
                Gizmos.DrawLine(mesh.vertices[triangles[j + 1]], mesh.vertices[triangles[j + 2]]);
                Gizmos.DrawLine(mesh.vertices[triangles[j + 2]], mesh.vertices[triangles[j]]);
            }
        }
        GL.PopMatrix();
    }
}
