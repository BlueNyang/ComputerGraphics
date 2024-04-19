using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarControl_0304 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = -Input.GetAxis("Horizontal");

        float speed = 100f;
        float barRotation = transform.eulerAngles.z + input * speed * Time.deltaTime;

        if(barRotation > 180) barRotation -= 360;
        barRotation = Mathf.Clamp(barRotation, -45, 45);

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, barRotation);
    }
}
