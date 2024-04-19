using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_0303_Script : MonoBehaviour
{
    [SerializeField] TMP_Text score_txt;
    [SerializeField] GameObject Ball;

    
    Dictionary<string, int> scores = new Dictionary<string, int>() {
        {"Red", 0},
        {"Blue", 0},
        {"Green", 0}
    };
    
    // Start is called before the first frame update
    void Start()
    {
        SetScoreText();
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetScoreText(){
        int red = scores["Red"];
        int blue = scores["Blue"];
        int green = scores["Green"];
        score_txt.text = $@"Red: {red}, Blue: {blue}, Green: {green}";
    }

    public void AddScore(int addRed, int addBlue, int addGreen){
        scores["Red"] += addRed;
        scores["Blue"] += addBlue;
        scores["Green"] += addGreen;
        SetScoreText();
    }
    

    void SpawnBall() {
        GameObject gameObject = Instantiate(Ball, new(Random.Range(-0.2f, 0.2f), 8, 0), Quaternion.identity);
        gameObject.name = "Ball";
    }
}

