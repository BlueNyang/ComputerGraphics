using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float moveableRange = 6.45f;
    [SerializeField] float cannonPower = 1000f;

    [SerializeField] GameObject connonBallPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] DestroyObj destroyObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime ,0 ,0);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -moveableRange, moveableRange), transform.position.y);

        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject _newBall = Instantiate(connonBallPrefab, spawnPoint.position, Quaternion.identity);

            _newBall.GetComponent<Rigidbody2D>().AddForce(Vector3.up * cannonPower);
        }
    }
}
