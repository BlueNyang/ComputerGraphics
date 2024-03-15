using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Example2 : MonoBehaviour
{
    [SerializeField] readonly Button btn1;
    // Start is called before the first frame update
    void Start()
    {
        btn1.onClick.AddListener(
            () => {
                Debug.Log("Button1.Clicked");
            }
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
