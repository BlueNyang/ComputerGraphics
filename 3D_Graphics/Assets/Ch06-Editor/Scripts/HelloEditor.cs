using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloEditor : MonoBehaviour
{
    [SerializeField] string MyString = "";
    public string String{get{return MyString;}}
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(MyString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
