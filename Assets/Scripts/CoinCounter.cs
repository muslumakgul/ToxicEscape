using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text _myScoreText; //text oluşturduk ki yazı olarak yazdırabilelim
    public int scoreNum; //score sayımızı tutacak değer
    public AudioScript audioScript;
    void Start() //başlangıçta
    {
        scoreNum = PlayerPrefs.GetInt(nameof(scoreNum), scoreNum);
        _myScoreText.text = "" + scoreNum; //score 0 yazdırdık
    }
    
    // void Start()
    // {
    //     scoreNum = PlayerData.Instance.coinScore;
    //     _myScoreText.text = "Score: " + scoreNum;
    // }

    private void OnTriggerEnter2D(Collider2D coin) //coine temas ettiğimizde
    {
        if (coin.tag == "Coin") //temas ettiğimiz şey yani colliderın tag'i coin ise
        {
            scoreNum++; //scoreumu arttır
            audioScript.PlayCoinSound();
            Destroy(coin.gameObject); //temas ettiğim coini yok et
            _myScoreText.text = "" + scoreNum; //scoreumu yaz
            PlayerPrefs.SetInt(nameof(scoreNum),scoreNum);
        }
    }

    void sifirla()
    {
        PlayerPrefs.DeleteKey(nameof(scoreNum));
    }

    void Update()
    {
        
    }
}
