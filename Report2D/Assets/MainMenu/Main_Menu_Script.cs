using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_Menu_Script : MonoBehaviour
{
    [SerializeField] Button startKunoichiBtn;
    [SerializeField] Button startOrbBtn;
    [SerializeField] Button exitBtn;
    // Start is called before the first frame update
    void Start()
    {
        startKunoichiBtn.onClick.AddListener(() =>
        {
            Debug.Log("Start Kunoichi Button Clicked");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Platform_Start");
        });

        startOrbBtn.onClick.AddListener(() =>
        {
            Debug.Log("Start Orb Button Clicked");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Orb");
        });

        exitBtn.onClick.AddListener(() =>
        {
            Debug.Log("Exit Button Clicked");
            Application.Quit();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
