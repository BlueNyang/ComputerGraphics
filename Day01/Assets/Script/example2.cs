using UnityEngine;
using UnityEngine.UI;

public class Example2 : MonoBehaviour
{
    [SerializeField] Button btn1;
    [SerializeField] Button btnDrawLine;
    // Start is called before the first frame update
    void Start()
    {
        btn1.onClick.AddListener(
            () =>
            {
                Debug.Log("Button1.Clicked");

                GameObject triangle = new GameObject("triangle");
            }
        );

        btnDrawLine.onClick.AddListener(
            () =>
            {
                Debug.Log("Draw Line");
                GameObject lineObj = new GameObject("line_object");

                LineRenderer lineRenderer = lineObj.AddComponent<LineRenderer>();

                int pointCount = 2;
                Vector3[] points = new Vector3[2];

                points[0] = new Vector3(0, 0, 0);
                points[1] = new Vector3(5, 0, 0);



                lineRenderer.positionCount = pointCount;
                lineRenderer.SetPositions(points);
                lineRenderer.startWidth = 0.05f;

                lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
                lineRenderer.material.color = Color.red;
            }
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
