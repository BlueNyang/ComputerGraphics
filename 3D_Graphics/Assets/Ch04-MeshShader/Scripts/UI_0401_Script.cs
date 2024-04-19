using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_0401_Script : MonoBehaviour
{
    [SerializeField] Button btnDrawTri;

    // Start is called before the first frame update
    void Start()
    {
        btnDrawTri.onClick.AddListener(() => {
            Debug.Log("Draw Triangle");

            GameObject gameObject = new("Triangle");

            MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();

            Mesh mesh = new();
            meshFilter.mesh = mesh;

            Vector3[] vertices = {
                new(-0.5f, -0.5f, 0),
                new(0, 0.5f, 0),
                new(0.5f, -0.5f, 0),
            };

            mesh.vertices = vertices;

            int[] triangles = { 0, 1, 2 };
            mesh.triangles = triangles;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();

            meshRenderer.material = new(Shader.Find("Custom/SimpleColor")); //{ color = new(0, 1, 0, 1)};
            meshRenderer.material.SetColor("_Color", new(0, 1, 0, 1));
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
