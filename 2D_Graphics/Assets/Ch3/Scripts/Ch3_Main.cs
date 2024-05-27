using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3_Main : MonoBehaviour
{
    public GameObject boom_prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            Instantiate(boom_prefab, mousePos, Quaternion.identity);
        }
    }
}
