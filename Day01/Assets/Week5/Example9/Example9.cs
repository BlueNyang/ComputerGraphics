using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Example9 : MonoBehaviour
{
    [SerializeField] Button btnDrawTri;
    // Start is called before the first frame update
    void Start()
    {
        btnDrawTri.onClick.AddListener( () => {
                Debug.Log("Draw Triangle");

                GameObject gameObj = new ("lineRenderer");
                MeshFilter meshFilter = gameObj.AddComponent<MeshFilter>();
                MeshRenderer meshRdr = gameObj.AddComponent<MeshRenderer>();

                Mesh mesh = new();

                meshFilter.mesh = mesh;

                Vector3[] vertices = {
                    new (-0.5f, -0.5f, 0),
                    new (0, 0.5f, 0),
                    new (0.5f, -0.5f, 0)
                };
                mesh.vertices = vertices;

                int[] triangles = new int[3]{0, 1, 2};
                mesh.triangles = triangles;

                mesh.RecalculateNormals();
                mesh.RecalculateBounds();

                meshRdr.material = new Material(Shader.Find("Custom/Color")); //{ color = new(0, 0, 1, 1) };
                meshRdr.material.SetColor("BaseColor", new Color(0, 1, 0, 1));

            }
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
