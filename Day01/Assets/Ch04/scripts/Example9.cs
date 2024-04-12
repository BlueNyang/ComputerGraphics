using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Example9 : MonoBehaviour
{
    [SerializeField] Button drawTriBtn;
    [SerializeField] Button drawRectBtn;
    [SerializeField] Button colorBtn;
    [SerializeField] Button textureBtn;

    [SerializeField] Texture2D texture;
    // Start is called before the first frame update
    void Start()
    {
        drawTriBtn.onClick.AddListener(() => {
            Debug.Log("draw Triangle");

            GameObject gameObject = new ("Triangle");
            MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();

            Mesh mesh = new Mesh();
            meshFilter.mesh = mesh;

            Vector3[] vertices = {
                new Vector3(-1.5f, 0, 0),
                new Vector3(-1.0f, 0.5f, 0),
                new Vector3(-0.5f, 0, 0)
            };

            mesh.vertices = vertices;

            int[] triangles = { 0, 1, 2 };
            mesh.triangles = triangles;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
            
            meshRenderer.material = new Material(Shader.Find("Standard"));

        });

        drawRectBtn.onClick.AddListener(() => {
            GameObject _obj = new("rect");
            MeshFilter meshFilter = _obj.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = _obj.AddComponent<MeshRenderer>();

            Mesh mesh = new();
            meshFilter.mesh = mesh;

            Vector3[] vertices = {
                new Vector3(-0.5f, -0.5f, 0),
                new Vector3(-0.5f, 0.5f, 0),
                new Vector3(0.5f, 0.5f, 0),
                new Vector3(0.5f, -0.5f, 0)
            };

            mesh.vertices = vertices;

            int[] triangle = {
                0, 1, 2,
                0, 2, 3,
            };
            mesh.triangles = triangle;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();

            meshRenderer.material = new Material(Shader.Find("Standard"));

        });

        colorBtn.onClick.AddListener(() => {
            GameObject _obj = new("rect");
            MeshFilter meshFilter = _obj.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = _obj.AddComponent<MeshRenderer>();

            Mesh mesh = new();
            meshFilter.mesh = mesh;

            Vector3[] vertices = {
                new Vector3(-0.5f, -0.5f, 0),
                new Vector3(-0.5f, 0.5f, 0),
                new Vector3(0.5f, 0.5f, 0),
                new Vector3(0.5f, -0.5f, 0)
            };

            mesh.vertices = vertices;

            int[] triangle = {
                0, 1, 3,
                1, 2, 3,
            };
            mesh.triangles = triangle;

            Color[] colors = {
                new Color(1, 0, 0, 1),
                new Color(0, 1, 0, 1),
                new Color(0, 0, 1, 1),
                new Color(1, 1, 1, 1)
            };

            mesh.colors = colors;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();

            meshRenderer.material = new Material(Shader.Find("Custom/simpleColor"));

        });

        textureBtn.onClick.AddListener(() => {
            GameObject _obj = new("rect");
            MeshFilter meshFilter = _obj.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = _obj.AddComponent<MeshRenderer>();

            Mesh mesh = new();
            meshFilter.mesh = mesh;

            Vector3[] vertices = {
                new Vector3(-0.5f, -0.5f, 0),
                new Vector3(-0.5f, 0.5f, 0),
                new Vector3(0.5f, 0.5f, 0),
                new Vector3(0.5f, -0.5f, 0)
            };

            mesh.vertices = vertices;

            int[] triangle = {
                0, 1, 3,
                1, 2, 3,
            };
            mesh.triangles = triangle;

            mesh.RecalculateNormals();
            mesh.RecalculateBounds();

            meshRenderer.material = new Material(Shader.Find("Standard"));

            meshRenderer.material.mainTexture = texture;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
