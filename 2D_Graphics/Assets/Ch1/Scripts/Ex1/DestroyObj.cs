using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    [SerializeField] float deleteTime = 3.0f;
    [SerializeField] string Collider_Target = "Floor";
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.collider.gameObject.name == Collider_Target){
            Debug.Log($@"Collision enter: {collision.collider.gameObject.name}");
            Destroy(gameObject, deleteTime);
        }
    }
}
