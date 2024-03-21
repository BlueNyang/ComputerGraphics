using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class example3 : MonoBehaviour
{
    [SerializeField] private Button triangle_btn;
    [SerializeField] private Button sqrt_btn;
    [SerializeField] private Button sin_btn;
    [SerializeField] private Button cos_btn;
    [SerializeField] private Button clr_btn;

    // Start is called before the first frame update
    void Start()
    {
        triangle_btn.onClick.AddListener(
            () => {
                Debug.Log("Draw Triangle");
                GameObject lineObj = new GameObject("tri_object");

                LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

                int pointCount = 4;
                Vector3[] points = new Vector3[pointCount];

                points[0] = new Vector3(-5, 0, 0);
                points[1] = new Vector3(0, 5, 0);
                points[2] = new Vector3(5, 0, 0);
                points[3] = new Vector3(-5, 0, 0);

                lineRenderer.positionCount = pointCount;
                lineRenderer.SetPositions(points);
                lineRenderer.startWidth = 0.05f;

                lineRenderer.material = new Material(Shader.Find("Unlit/Color"))
                {
                    color = Color.red
                };
            }
        );

        sqrt_btn.onClick.AddListener(
            () => {
                Debug.Log("Draw Square");
                GameObject lineObj = new GameObject("sqrt_object");

                LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

                int pointCount = 5;
                Vector3[] points = new Vector3[pointCount];

                points[0] = new Vector3(-5, 0, 0);
                points[1] = new Vector3(0, 0, 0);
                points[2] = new Vector3(0, 5, 0);
                points[3] = new Vector3(-5, 5, 0);
                points[4] = new Vector3(-5, 0, 0);

                lineRenderer.positionCount = pointCount;
                lineRenderer.SetPositions(points);
                lineRenderer.startWidth = 0.05f;

                lineRenderer.material = new Material(Shader.Find("Unlit/Color"))
                {
                    color = Color.red
                };
            }
        );

        sin_btn.onClick.AddListener(
            () => {
                Debug.Log("Draw Sin");
                GameObject lineObj = new GameObject("sin_object");

                LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

                int pointCount = 180;
                Vector3[] points = new Vector3[pointCount];

                float xRange = MathF.PI * 2;

                for(int i = 0; i < pointCount; i++){
                    float x = i / (float)pointCount * xRange;
                    float y = MathF.Sin(x);

                    points[i] = new Vector3(x, y, 0);
                }

                lineRenderer.positionCount = pointCount;
                lineRenderer.SetPositions(points);
                lineRenderer.startWidth = 0.05f;

                lineRenderer.material = new Material(Shader.Find("Unlit/Color"))
                {
                    color = Color.green
                };
            }
        );

        cos_btn.onClick.AddListener(
            () => {
                Debug.Log("Draw Sine");
                GameObject lineObj = new GameObject("cos_object");

                LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

                int pointCount = 180;
                Vector3[] points = new Vector3[pointCount];

                float xRange = MathF.PI * 2;

                for(int i = 0; i < pointCount; i++){
                    float x = i / (float)pointCount * xRange;
                    float y = MathF.Cos(x);

                    points[i] = new Vector3(x, y, 0);
                }

                lineRenderer.positionCount = pointCount;
                lineRenderer.SetPositions(points);
                lineRenderer.startWidth = 0.05f;

                lineRenderer.material = new Material(Shader.Find("Unlit/Color"))
                {
                    color = Color.green
                };
            }
        );

        clr_btn.onClick.AddListener(
            ()=>{
                GameObject[] obj = new GameObject[4];
                obj[0] = GameObject.Find("tri_object");
                obj[1] = GameObject.Find("sqrt_object");
                obj[2] = GameObject.Find("sin_object");
                obj[3] = GameObject.Find("cos_object");

                for(int i = 0; i< 4; i++){
                    Destroy(obj[i]);
                }
            }
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
