using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_0802_Script : MonoBehaviour
{
    [SerializeField] Button btnStart;
    // Start is called before the first frame update
    void Start()
    {
        btnStart.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Example2_1");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
