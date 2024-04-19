using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Main_0304 : MonoBehaviour
{
    [SerializeField] GameObject redBall;
    [SerializeField] GameObject blueBall;

    int nScore = 0;
    [SerializeField] TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = $@"Score: {nScore}";

        StartCoroutine(SpawnBalls());
    }

    public void AddScore(int num){
        nScore += num;
        scoreText.text = $@"Score: {nScore}";
    }

    IEnumerator SpawnBalls(){
        while(true){
            GameObject Ball;
            yield return new WaitForSeconds(2f);

            int result = Random.Range(0, 2);
            if(result == 0)
                Ball_Set(out Ball, redBall);
            else
                Ball_Set(out Ball, blueBall);

            float addGravity = 2f;
            Ball.GetComponent<Rigidbody>().AddForce(Vector3.down * addGravity, ForceMode.Impulse);
        }
    }

    void Ball_Set(out GameObject Ball, GameObject instantBall){
        Ball = Instantiate(instantBall, new(Random.Range(-0.5f, 0.5f), 10, 0), Quaternion.identity);
    }
}
