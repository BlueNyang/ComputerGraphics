using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl_0304 : MonoBehaviour
{
    Rigidbody rdbd;
    Main_0304 scoreManager;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        rdbd = GetComponent<Rigidbody>();
        scoreManager = FindAnyObjectByType<Main_0304>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rdbd.IsSleeping()){
            rdbd.WakeUp();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        string myTag = gameObject.tag;
        string colTag = collision.gameObject.tag;

        if(colTag == "redBoard"){
            if(myTag == "redBall") scoreManager.AddScore(1);
            else scoreManager.AddScore(-1);
            Destroy(gameObject);
        }
        else if(colTag == "blueBoard"){
            if (myTag == "redBall") scoreManager.AddScore(-1);
            else scoreManager.AddScore(1);
            Destroy(gameObject);
        }

    }
}
