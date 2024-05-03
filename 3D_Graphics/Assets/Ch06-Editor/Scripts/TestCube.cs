using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCube : MonoBehaviour
{
    public float baseSize = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        applySize();
    }

    public void applySize(){
        transform.localScale = baseSize * Vector3.one;
    }
}
