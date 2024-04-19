using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using Unity.VisualScripting;
using System;

public class UI_0202_Script : MonoBehaviour
{
    [SerializeField] TMP_Text mPos_Text;
    [SerializeField] TMP_Text wPos_Text;

    Vector3[] vertices = {
        new(-1, 0, 0),
        new(0, 1, 0),
        new(1, 0, 0),
        new(0, -1, 0),
    };

    GameObject draw_obj;
    // Start is called before the first frame update
    void Start()
    {
        draw_obj = new("draw_obj");

        GameObject shape_obj = DrawShape(vertices, Color.red);
        shape_obj.transform.position = new(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown((int)MouseButton.Left) && !EventSystem.current.IsPointerOverGameObject()){
            Vector3 mPos = Input.mousePosition;

            string position_str = $@"Mouse Pos: {mPos.x}, {mPos.y}, {mPos.z}";
            Debug.Log($@"Mouse Left Clicked - {position_str}");
            mPos_Text.text = position_str;

            GameObject gameObject = DrawShape(vertices, Color.green);

            mPos.z = 10;

            Vector3 wPos = Camera.main.ScreenToWorldPoint(mPos);

            wPos_Text.text = $@"World Pos: {Math.Round(wPos.x, 2)}, {Math.Round(wPos.y, 2)}, {Math.Round(wPos.z, 2)}";

            gameObject.transform.position = wPos;
        }
    }

    private GameObject DrawShape(Vector3[] vertices, Color clr){
        GameObject _gameObj = new("any_shapes");
        _gameObj.transform.SetParent(draw_obj.transform);

        LineRenderer lineRenderer = _gameObj.AddComponent<LineRenderer>();

        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        lineRenderer.useWorldSpace = false;
        lineRenderer.positionCount = vertices.Length;

        lineRenderer.SetPositions(vertices);
        lineRenderer.loop = true;

        lineRenderer.material = new(Shader.Find("Unlit/Color")){ color = clr };

        return _gameObj;
    }
}
