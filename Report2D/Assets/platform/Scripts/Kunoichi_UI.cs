using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Kunoichi_UI : MonoBehaviour
{
    [SerializeField] TMP_Text hpText;
    [SerializeField] GameObject hpBar;
    [SerializeField] GameObject playerObject;
    [SerializeField] Button test_HitBtn;
    [SerializeField] Button back_Btn;

    Kunoichi player;
    // Start is called before the first frame update
    void Start()
    {
        player = playerObject.GetComponent<Kunoichi>();

        test_HitBtn.onClick.AddListener(() =>
        {
            Debug.Log("Hit Button Clicked");
            player.TakeDamage(10.0f);
        });

        back_Btn.onClick.AddListener(() =>
        {
            Debug.Log("Back Button Clicked");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Platform_Start");
        });
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHp();
    }

    void UpdateHp()
    {
        var hp = player.HP;
        var maxHp = player.MaxHP;
        hpText.text = $"HP: {hp}/{maxHp}";

        var hpBarWidth = GetComponent<RectTransform>().rect.width;
        var hpBarRect = hpBar.GetComponent<RectTransform>();
        var nWidth = hpBarWidth * hp / maxHp;
        hpBarRect.sizeDelta = new Vector2(nWidth, hpBarRect.rect.height);
    }
}
