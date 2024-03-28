using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

public class example4 : MonoBehaviour
{
    [SerializeField] TMP_Text mousePos_text;
    [SerializeField] TMP_Text world_mPos_text;
    
    Vector3[] vertices = {
        new Vector3(-1, 0, 0),
        new Vector3(0, 1, 0),
        new Vector3(1, 0, 0),
        new Vector3(0, -1, 0)
    };
    // Start is called before the first frame update
    void Start()
    {

        GameObject Obj = DrawShape(vertices, new Color(1, 0, 0));
        Obj.transform.position = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown((int)MouseButton.Left) && !EventSystem.current.IsPointerOverGameObject()){
            Vector3 mpos = Input.mousePosition;
            string position_str = $@"mouse pos : {mpos.x:f}, {mpos.y:f}, {mpos.z:f}";
            Debug.Log(position_str);
            mousePos_text.text = position_str;

            GameObject gObj = DrawShape(vertices, new Color(0 ,1, 0));

            mpos.z = 10;
            Vector3 mpos_world = Camera.main.ScreenToWorldPoint(mpos);
            world_mPos_text.text = $@"world pos : {mpos_world.x}, {mpos_world.y}, {mpos_world.z}";
            

            gObj.transform.position = mpos_world;
        }
    }

    private GameObject DrawShape(Vector3[] vertices, Color clr){
        GameObject _gameObj = new GameObject("any_shapes");
        LineRenderer lineRdr = _gameObj.AddComponent<LineRenderer>();

        lineRdr.startWidth = 0.05f;
        lineRdr.endWidth = 0.05f;
        lineRdr.useWorldSpace = false;
        lineRdr.positionCount = vertices.Length;

        lineRdr.SetPositions(vertices);
        lineRdr.loop = true;

        lineRdr.material = new Material(Shader.Find("Unlit/Color")){ color = clr };
        
        return _gameObj;
    }
}
