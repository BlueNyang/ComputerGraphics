using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBalls : MonoBehaviour
{
    [SerializeField] float deleteTime = 0.0f;
    [SerializeField] GameObject target_Obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Debug.Log($@"Collision enter: {collision.collider.gameObject}");
        if(collision.collider.gameObject.name == $@"{target_Obj.name}(Clone)"){
            Destroy(gameObject, deleteTime);
        }
    }
}
