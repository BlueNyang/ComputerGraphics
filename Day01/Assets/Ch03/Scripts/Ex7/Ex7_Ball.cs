using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ex7_Ball : MonoBehaviour
{
    [SerializeField] Example7 ex7;
    [SerializeField] Rigidbody rdbd;

    Dictionary<string, int> scores;
    // Start is called before the first frame update
    void Start()
    {
        //CreateBall();
        SetRdbdDefPos();

        scores = new Dictionary<string, int>() {
            {"RedGround", 0},
            {"BlueGround", 0},
            {"GreenGround", 0}
        };

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
        if(scores.ContainsKey(objName))
        {
            Debug.Log(objName + " collision");
            scores[objName]++;
            rdbd.Sleep();
            rdbd.WakeUp();
            SetRdbdDefPos();
            ex7.SetScoreText(scores["RedGround"], scores["BlueGround"], scores["GreenGround"]);
        }
    }

    void CreateBall(){
        rdbd = gameObject.GetComponent<Rigidbody>();
    }

    void SetRdbdDefPos(){
        rdbd.position = new Vector3(Random.Range(-0.125f, 0.125f), 8, 0);
    }
}
