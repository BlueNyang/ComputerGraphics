using UnityEngine;
using UnityEngine.UI;

public class Platform_Start_UI : MonoBehaviour
{
    [SerializeField] Button startBtn;
    [SerializeField] Button exitBtn;

    // Start is called before the first frame update
    void Start()
    {
        startBtn.onClick.AddListener(() =>
        {
            Debug.Log("Start Button Clicked");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Platform");
        });

        exitBtn.onClick.AddListener(() =>
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
        });
    }
}
