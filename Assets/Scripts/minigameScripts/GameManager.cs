using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public PlayAgain playAgain;
    [Header("Player 1")]
    public GameObject player1paddle;
    public GameObject player1Goal;
    public GameObject player1Text;
    
    [Header("Player 2")]
    public GameObject player2paddle;
    public GameObject player2Goal;
    public GameObject player2Text;

    private int player1Score;
    private int player2Score;

    public void player1Scored()
    {
        player1Score++;
        player1Text.GetComponent<Text>().text = player1Score.ToString();
        resetPosition();
        if (player1Score == 3)
        {
            Debug.Log("TEBRIKLER KAZANDINIZ!");
        }
    }
    public void player2Scored()
    {
        player2Score++;
        player2Text.GetComponent<Text>().text = player2Score.ToString();
        resetPosition();
        if (player2Score == 3)
        {
            Debug.Log("KAYBETTINIZ");
        }
    }

    public void resetPosition()
    {
        ball.GetComponent<BallMovement>().Reset();
        player1paddle.GetComponent<Paddle>().Reset();
        player2paddle.GetComponent<Paddle>().Reset();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
