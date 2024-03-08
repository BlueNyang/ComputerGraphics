using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    [SerializeField]
    Button mBtnTest01;

    [SerializeField]
    Button mBtnTest02;

    [SerializeField]
    Image mBtnImage01;

    // Start is called before the first frame update
    void Start()
    {
        mBtnTest01.onClick.AddListener(() =>
        {
            Debug.Log("20202717 안규태 test1 Clicked");

            mBtnImage01.color = Color.blue;
        });


        mBtnTest02.onClick.AddListener(() =>
        {
            Debug.Log("20202717 안규태 test2 Clicked");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
