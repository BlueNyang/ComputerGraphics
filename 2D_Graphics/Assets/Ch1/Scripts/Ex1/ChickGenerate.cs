using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickGenerate : MonoBehaviour
{
    [SerializeField] GameObject prefeb_ChickBall;
    [SerializeField] float interval = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 0.1f, interval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnObject(){
        Instantiate(prefeb_ChickBall, transform.position, transform.rotation);
    }
}
