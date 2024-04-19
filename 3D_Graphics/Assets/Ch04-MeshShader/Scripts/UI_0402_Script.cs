using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_0402_Script : MonoBehaviour
{
    [SerializeField] Button btnDrawTri;
    [SerializeField] Button btnDrawRect;
    [SerializeField] Button btnClrIndex;
    [SerializeField] Button btnUnlitTexture;
    [SerializeField] Button btnCustomTexture;
    [SerializeField] Button btnClear;

    [SerializeField] Texture2D texture;
    // Start is called before the first frame update
    void Start()
    {
        GameObject dynamicObj = new("dynamic_objects");

        btnDrawTri.onClick.AddListener(() =>{
            Debug.Log("Draw Triangle with Unlit Shader");

            GameObject gameObject = new("Triangle");
            gameObject.transform.SetParent(dynamicObj.transform);

            gameObject.transform.position = new(0, 0, 0);
            gameObject.transform.localScale = new(1, 1, 1);
            gameObject.transform.Rotate(0, 0, 0);

            MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();

            Mesh mesh = new();
            meshFilter.mesh = mesh;

            Vector3[] vertices = {
                new(-1f, -0.5f, 0),
                new(0, MathF.Tan(Mathf.Deg2Rad * 60) - 0.5f, 0),
                new(1f, -0.5f, 0)
            };
            mesh.vertices = vertices;

            int[] triangles = {0, 1, 2};
            mesh.triangles = triangles;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();

            meshRenderer.material = new(Shader.Find("Unlit/Color")){ color = new(1, 0, 0, 1) };
        }); 

        btnDrawRect.onClick.AddListener(() =>{
            Debug.Log("Draw Rectangle with Custom Shader");

            GameObject gameObject = new("Rectangle");
            gameObject.transform.SetParent(dynamicObj.transform);

            gameObject.transform.position = new(0, 0, 0);
            gameObject.transform.localScale = new(1, 1, 1);
            gameObject.transform.Rotate(0, 0, 0);

            MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();

            Mesh mesh = new();
            meshFilter.mesh = mesh;

            Vector3[] vertices = {
                new(-1f, 1f, 0),
                new(1f, 1f, 0),
                new(1f, -1f, 0),
                new(-1f, -1f, 0),
            };
            mesh.vertices = vertices;

            int[] triangles = { 0, 1, 2, 0, 2, 3, };
            mesh.triangles = triangles;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();

            meshRenderer.material = new(Shader.Find("Custom/SimpleColor")){ color = new(0, 1, 0, 1) };
            //or meshRenderer.material.SetColor("_Color", new(1, 0, 0, 1));
        });

        btnClrIndex.onClick.AddListener(() => {
            Debug.Log("Vertex Color Shader color index");

            GameObject gameObject = new("Vertex_Color_Index_Obj");
            gameObject.transform.SetParent(dynamicObj.transform);

            gameObject.transform.position = new(0, 0, 0);
            gameObject.transform.localScale = new(1, 1, 1);
            gameObject.transform.Rotate(0, 0, 0);

            MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();

            Mesh mesh = new();
            meshFilter.mesh = mesh;

            Vector3[] vertices = {
                new(-1f, 1f, 0),
                new(1f, 1f, 0),
                new(1f, -1f, 0),
                new(-1f, -1f, 0),
            };
            mesh.vertices = vertices;

            int[] triangles = { 0, 1, 2, 2, 3, 0, };
            mesh.triangles = triangles;

            Color[] colors = {
                Color.red,
                Color.green,
                Color.blue,
                new(1, 1, 1, 1),
            };
            mesh.colors = colors;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();

            meshRenderer.material = new(Shader.Find("Custom/VertexColor"));
        });

        btnUnlitTexture.onClick.AddListener(() => {
            Debug.Log("Unlit Texture Shader");

            GameObject gameObject = new("Unlit_Texture_Obj");
            gameObject.transform.SetParent(dynamicObj.transform);

            gameObject.transform.position = new(0, 0, 0);
            gameObject.transform.localScale = new(1, 1, 1);
            gameObject.transform.Rotate(0, 0, 0);

            MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();

            Mesh mesh = new();
            meshFilter.mesh = mesh;

            Vector3[] vertices = {
                new(-1f, 1f, 0),
                new(1f, 1f, 0),
                new(1f, -1f, 0),
                new(-1f, -1f, 0),
            };
            mesh.vertices = vertices;

            int[] triangles = { 0, 1, 2, 2, 3, 0, };
            mesh.triangles = triangles;

            Vector2[] uvs = {
                new(0, 1),
                new(1, 1),
                new(1, 0),
                new(0, 0),
            };
            mesh.uv = uvs;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();

            meshRenderer.material = new(Shader.Find("Unlit/Texture")){ mainTexture = texture };
        });

        btnCustomTexture.onClick.AddListener(() => {
            Debug.Log("Custom Texture Shader");

            GameObject gameObject = new("Custom_Texture_Obj");
            gameObject.transform.SetParent(dynamicObj.transform);

            gameObject.transform.position = new(0, 0, 0);
            gameObject.transform.localScale = new(1, 1, 1);
            gameObject.transform.Rotate(0, 0, 0);

            MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();

            Mesh mesh = new();
            meshFilter.mesh = mesh;

            Vector3[] vertices = {
                new(-1f, 1f, 0),
                new(1f, 1f, 0),
                new(1f, -1f, 0),
                new(-1f, -1f, 0),
            };
            mesh.vertices = vertices;

            int[] triangles = { 0, 1, 2, 2, 3, 0, };
            mesh.triangles = triangles;

            Vector2[] uvs = {
                new(0, 1),
                new(1, 1),
                new(1, 0),
                new(0, 0),
            };
            mesh.uv = uvs;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();

            meshRenderer.material = new(Shader.Find("Custom/SimpleTexture")){mainTexture = texture};
        });

        btnClear.onClick.AddListener(() => {
            Destroy(dynamicObj);
            dynamicObj = new("dynamic_objects");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
