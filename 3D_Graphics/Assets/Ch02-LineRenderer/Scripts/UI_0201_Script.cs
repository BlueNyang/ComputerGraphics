using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_0201_Script : MonoBehaviour
{
    [SerializeField] Button btnTest;
    [SerializeField] Button drawLine;
    [SerializeField] Button drawTri;
    [SerializeField] Button drawSqrt;
    [SerializeField] Button drawSin;
    [SerializeField] Button drawCos;
    [SerializeField] Button btnClear;

    // Start is called before the first frame update
    void Start()
    {
        GameObject draw_obj = new("draw_object");
        btnTest.onClick.AddListener(() => {
            Debug.Log("Test Button Clicked");
        });

        drawLine.onClick.AddListener(() => {
            Debug.Log("Draw Line");
            GameObject lineObj = new("Line_Object");
            lineObj.transform.SetParent(draw_obj.transform);

            LineRenderer lineRdr = lineObj.AddComponent<LineRenderer>();

            Vector3[] points = new Vector3[2]{
                new(0, 0, 0),
                new(5, 0, 0)
            };

            lineRdr.positionCount = points.Length;
            lineRdr.SetPositions(points);
            lineRdr.startWidth = 0.05f;

            lineRdr.material = new Material(Shader.Find("Unlit/Color")){
                color = Color.red
            };
        });

        drawTri.onClick.AddListener(() => {
            Debug.Log("Draw Triangle");

            GameObject lineObj = new("Triangle_Object");
            lineObj.transform.SetParent(draw_obj.transform);

            LineRenderer lineRdr = lineObj.AddComponent<LineRenderer>();

            Vector3[] points = new Vector3[3]{
                new(-5, 0, 0),
                new (0, 5, 0),
                new(5, 0 , 0)
            };

            lineRdr.positionCount = points.Length;
            lineRdr.SetPositions(points);
            lineRdr.startWidth = 0.05f;
            lineRdr.loop = true;

            lineRdr.material = new(Shader.Find("Unlit/Color")){
                color = Color.blue
            };
            
        });

        drawSqrt.onClick.AddListener(() => {
            Debug.Log("Draw Square");
            GameObject lineObj = new("Square_Object");
            lineObj.transform.SetParent(draw_obj.transform);

            LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

            Vector3[] points = new Vector3[4]{
                new(0, 0, 0),
                new(5, 0, 0),
                new(5, 5, 0),
                new(0, 5, 0)
            };

            lineRenderer.positionCount = points.Length;
            lineRenderer.SetPositions(points);
            lineRenderer.startWidth = 0.05f;
            lineRenderer.loop = true;

            lineRenderer.material = new(Shader.Find("Unlit/Color")){
                color = Color.blue
            };
        });

        drawSin.onClick.AddListener(() => {
            Debug.Log("Draw Sin Graph");

            GameObject lineObj = new("Sin_Object");
            lineObj.transform.SetParent(draw_obj.transform);

            LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

            int pointCount = 180;
            Vector3[] points = new Vector3[pointCount];

            float xRange = MathF.PI * 2;

            for(int i = 0; i < pointCount; i++){
                float x = i / (float)pointCount * xRange; //convert theta(x) from degrees to radians
                float y = MathF.Sin(x); //Sin(theta); y-axis value

                points[i] = new(x, y, 0);
            }

            lineRenderer.positionCount = points.Length;
            lineRenderer.SetPositions(points);
            lineRenderer.startWidth = 0.05f;

            lineRenderer.material = new Material(Shader.Find("Unlit/Color")){
                color = Color.red
            };
        });
        
        drawCos.onClick.AddListener(() => {
            Debug.Log("Draw Cos Graph");
            GameObject lineObj = new("Cos_Object");
            lineObj.transform.SetParent(draw_obj.transform);

            LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

            int pointCount = 180;
            Vector3[] points = new Vector3[pointCount];

            float xRange = MathF.PI * 2;

            for(int i = 0; i < pointCount; i++){
                float x = i / (float)pointCount * xRange; //convert theta(x) from degrees to radians
                float y = Mathf.Cos(x); //Cos(theta); x-axis value

                points[i] = new(x, y, 0);
            }

            lineRenderer.positionCount = pointCount;
            lineRenderer.SetPositions(points);
            lineRenderer.startWidth = 0.05f;

            lineRenderer.material = new Material(Shader.Find("Unlit/Color")){
                color = Color.green
            };
        });

        btnClear.onClick.AddListener(() => {
            Debug.Log("Clear all of draw objects");

            Destroy(draw_obj);
            draw_obj = new("draw_object");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

