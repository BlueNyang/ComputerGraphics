using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_01_Script : MonoBehaviour
{
    [SerializeField] Button btn1;
    [SerializeField] Button btn2;
    [SerializeField] Image btn1_image;

    // Start is called before the first frame update
    void Start()
    {
        Color now_clr = Color.white;
        btn1.onClick.AddListener(() =>{
            Debug.Log("20202717 Ahn GyuTae test1 Clicked");

            if(now_clr == Color.white) now_clr = Color.blue;
            else now_clr = Color.white;
            btn1_image.color = now_clr;
        });

        btn2.onClick.AddListener(() =>{
            Debug.Log("20202717 Ahn GyuTae test2 Clicked");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

