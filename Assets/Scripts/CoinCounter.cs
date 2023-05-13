using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text _myScoreText; //text oluşturduk ki yazı olarak yazdırabilelim
    private int scoreNum; //score sayımızı tutacak değer
    
    void Start() //başlangıçta
    {
        scoreNum = 0; //scoreumu 0'dan başlat
        _myScoreText.text = "Score: " + scoreNum; //score 0 yazdırdık
    }

    private void OnTriggerEnter2D(Collider2D coin) //coine temas ettiğimizde
    {
        if (coin.tag == "Coin") //temas ettiğimiz şey yani colliderın tag'i coin ise
        {
            scoreNum++; //scoreumu arttır
            Destroy(coin.gameObject); //temas ettiğim coini yok et
            _myScoreText.text = "Score" + scoreNum; //scoreumu yaz
        }
    }

    void Update()
    {
        
    }
}