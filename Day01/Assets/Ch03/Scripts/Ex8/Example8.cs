using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.UI;

public class Example8 : MonoBehaviour
{
    [SerializeField] TMP_Text score_txt;
    [SerializeField] Material ball_material;
    
    // Start is called before the first frame update
    void Start()
    {
        SetScoreText(0, 0, 0);
        //CreateBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void SetScoreText(int red, int blue, int green){
        score_txt.text = $@"Red: {red}, Blue: {blue}, Green: {green}";
    }
    

    void CreateBall() {
        GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        gameObject.GetComponent<MeshRenderer>().material = ball_material;
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<Ex8_Ball>();
    }
}
