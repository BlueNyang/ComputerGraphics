using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl_0303 : MonoBehaviour
{
    [SerializeField] Rigidbody rdbd;
    [SerializeField] UI_0303_Script scoreManager;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        rdbd = GetComponent<Rigidbody>();
        scoreManager = FindObjectOfType<UI_0303_Script>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(rdbd.IsSleeping()) {
            rdbd.WakeUp();
        }
    }

    void OnCollisionEnter(Collision collision){
        string objName = collision.gameObject.name;
        Debug.Log(objName);

        if(objName == "RedGround"){
            ScoreUpdate(1, 0, 0);
        }
        else if(objName == "BlueGround"){
            ScoreUpdate(0, 1, 0);
        }
        else if(objName == "GreenGround"){
            ScoreUpdate(0, 0, 1);
        }
    }

    void ScoreUpdate(int red, int blue, int green){
        scoreManager.AddScore(red, blue, green);
        rdbd.Sleep();
        rdbd.WakeUp();
        rdbd.position = new Vector3(Random.Range(-0.2f, 0.2f), 8, 0);
    }
}

