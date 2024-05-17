using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_0802_01_Script : MonoBehaviour
{
    [SerializeField] Button btnBack;
    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Example2");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
