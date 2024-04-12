using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    [SerializeField] float deleteTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.collider.gameObject.name == "Floor"){
            Debug.Log($@"Collision enter: {collision.collider.gameObject.name}");
            Destroy(gameObject, deleteTime);
        }
    }
}
