using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Example5 : MonoBehaviour
{
    [SerializeField] private Button DrawCircle_Btn;

    // Start is called before the first frame update
    void Start()
    {
        DrawCircle_Btn.onClick.AddListener(
            () => {
                Debug.Log("Draw Circle");
                Draw_Circle(new Vector3(0, 0, 0 ), new Color(1, 0, 0), 0.5f, 32);
            }
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Draw_Circle(Vector3 centerPos, Color clr, float radious = 1, int segments = 32 ){
        GameObject circleObject = new GameObject("circle");
        LineRenderer lineRdr = circleObject.AddComponent<LineRenderer>();

        lineRdr.startWidth = 0.05f;
        lineRdr.endWidth = 0.05f;

        lineRdr.useWorldSpace = false;
        lineRdr.positionCount = segments;

        lineRdr.material = new Material(Shader.Find("Unlit/Color")) { color = clr };

        float shift = 360f / segments;
        float angle = 0f;

        for(int i = 0; i < segments; i++){
            float x = Mathf.Cos(Mathf.Deg2Rad * angle) * radious;
            float y = Mathf.Sin(Mathf.Deg2Rad * angle) * radious;

            lineRdr.SetPosition(i, new Vector3(x, y, 0));

            angle += shift;
        }

        lineRdr.loop = true;

        circleObject.transform.position = centerPos;

    }
}
