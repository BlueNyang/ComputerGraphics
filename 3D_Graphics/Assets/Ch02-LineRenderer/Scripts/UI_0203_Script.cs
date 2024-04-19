using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_0203_Script : MonoBehaviour
{
    [SerializeField] Button drawCircle;
    // Start is called before the first frame update
    void Start()
    {
        drawCircle.onClick.AddListener(() => {
            DrawCircle(new(-2, 0, 0), Color.red, 0.5f, 18);
            DrawCircle(new(0, 0, 0), Color.blue, 0.5f, 36);
            DrawCircle(new(2, 0, 0), Color.green, 0.5f, 288);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void DrawCircle(Vector3 centerPos, Color clr, float radious = 1, int segments = 36){

        GameObject circleObj = new("Circle_Object");
        LineRenderer lineRenderer = circleObj.AddComponent<LineRenderer>();

        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;

        lineRenderer.useWorldSpace = false;
        lineRenderer.positionCount = segments;

        lineRenderer.material = new(Shader.Find("Unlit/Color")){color = clr};

        float shift = 360f / segments;
        float angle = 0f;

        for(int i = 0; i < segments; i++){
            float x = MathF.Cos(Mathf.Deg2Rad * angle) * radious; //Cos(theta) * r. theta == angle / 180 * PI
            float y = MathF.Sin(Mathf.Deg2Rad * angle) * radious;

            lineRenderer.SetPosition(i, new(x, y, 0));

            angle += shift;
        }

        lineRenderer.loop = true;

        circleObj.transform.position = centerPos;
    }

}
