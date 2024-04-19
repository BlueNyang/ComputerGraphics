using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BarControl_0302 : MonoBehaviour
{
    [SerializeField] TMP_Text axis_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get left-right input
        float move = - Input.GetAxis("Horizontal");

        float speed = 90f;
        float newRotation = transform.eulerAngles.z + (move * speed * Time.deltaTime);

        if(newRotation > 180) newRotation -= 360;

        newRotation = Mathf.Clamp(newRotation, -45, 45);

        transform.rotation = Quaternion.Euler(
            transform.rotation.x,
            transform.rotation.y,
            newRotation
            );

        axis_text.text = $@"h value = {move}";
    }
}

