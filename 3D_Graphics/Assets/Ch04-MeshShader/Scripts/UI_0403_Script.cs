using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_0403_Script : MonoBehaviour
{
    [SerializeField] Button btnColor;
    [SerializeField] Button btnTexture;

    [SerializeField] Texture2D texture;
    [SerializeField] GameObject vertexGroup;
    // Start is called before the first frame update
    void Start()
    {
        btnColor.onClick.AddListener(() => {
            CreatePolygon(out GameObject polygon);
            MeshRenderer meshRenderer = polygon.AddComponent<MeshRenderer>();
            meshRenderer.material = new(Shader.Find("Unlit/Color")){ color = Color.blue };
        });

        btnTexture.onClick.AddListener(() =>{
            CreatePolygon(out GameObject polygon);
            MeshRenderer meshRenderer = polygon.AddComponent<MeshRenderer>();
            meshRenderer.material = new(Shader.Find("Unlit/Texture")){ mainTexture = texture };
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreatePolygon(out GameObject polygon){
        Transform[] children = vertexGroup.GetComponentsInChildren<Transform>();

        List<Vector3> verticesList = new();

        Vector3 center = new();

        foreach (var child in children){
            if(child == vertexGroup.transform){
                Debug.Log($@"Center: {child.name} - {child.position}");
                center = child.position;
            }
            else{
                Debug.Log($@"Children: {child.name} - {child.position}");
                verticesList.Add(child.position);
            }
        }

        Vector3[] vertices = verticesList.ToArray();
        
        polygon = new("polygon");

        polygon.transform.position = center;
        polygon.transform.localScale = new(1, 1, 1);
        polygon.transform.Rotate(0, 0, 0);

        MeshFilter meshFilter = polygon.AddComponent<MeshFilter>();

        Mesh mesh = new();
        meshFilter.mesh = mesh;

        mesh.vertices = vertices;

        Vector2[] uvs = {
            new(0, 1),
            new(1, 1),
            new(1, 0),
            new(0, 0),
        };
        mesh.uv = uvs;

        mesh.triangles = new int[] { 0, 1, 2, 0, 2, 3, };

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
    }
}
