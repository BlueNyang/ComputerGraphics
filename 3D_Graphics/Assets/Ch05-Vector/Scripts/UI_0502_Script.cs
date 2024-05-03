using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_0502_Script : MonoBehaviour
{
    [SerializeField] TMP_Text tx_info;
    [SerializeField] GameObject ArrowObj;
    [SerializeField] float Speed = 1.0f;
    [SerializeField] float Turn_Speed = 50.0f;
    [SerializeField] Camera MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 pos = ArrowObj.transform.position;
        pos.x += 1.0f * Time.deltaTime;
        ArrowObj.transform.position = pos;
        */

        if(!(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))){
            if(Input.GetKey(KeyCode.W)){
                ArrowObj.transform.Translate(Vector3.forward * Time.deltaTime * Speed);
            }
            else if(Input.GetKey(KeyCode.S)){
                ArrowObj.transform.Translate(Vector3.back * Time.deltaTime * Speed);
            }
        }

        if(!(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))){
            if(Input.GetKey(KeyCode.A)){
                ArrowObj.transform.Translate(Vector3.left * Time.deltaTime * Speed);
            }
            else if(Input.GetKey(KeyCode.D)){
                ArrowObj.transform.Translate(Vector3.right * Time.deltaTime * Speed);
            }
        }

        if(!(Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E))){
            if(Input.GetKey(KeyCode.Q)){
                ArrowObj.transform.Rotate(Vector3.down * Time.deltaTime * Turn_Speed);
            }
            else if(Input.GetKey(KeyCode.E)){
                ArrowObj.transform.Rotate(Vector3.up * Time.deltaTime * Turn_Speed);
            }
        }

        tx_info.text = $@"front Vector: {ArrowObj.transform.forward}
        position: {ArrowObj.transform.position}";

        if(!(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow)) && !(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))){
            if(Input.GetKey(KeyCode.UpArrow)){
                MainCamera.transform.Rotate(Vector3.left * Time.deltaTime * Turn_Speed);
            }
            else if(Input.GetKey(KeyCode.DownArrow)){
                MainCamera.transform.Rotate(Vector3.right * Time.deltaTime * Turn_Speed);
            }
            if(Input.GetKey(KeyCode.LeftArrow)){
                MainCamera.transform.Rotate(new Vector3(0, 1 * Time.deltaTime * Turn_Speed, 0));
            }
            else if(Input.GetKey(KeyCode.RightArrow)){
                MainCamera.transform.Rotate(new Vector3(0, -1 * Time.deltaTime * Turn_Speed, 0));
            }
        }

        //ArrowObj.transform.Translate(Vector3.right * Time.deltaTime * Speed);
    }
}

