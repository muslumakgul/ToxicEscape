using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheck : MonoBehaviour
{
    public AudioScript audioScript;
    public bool isPlayer1Goal;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            if (!isPlayer1Goal)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().player2Scored();
                audioScript.playGoalSound();
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().player1Scored();
                audioScript.playGoalSound();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void OnCollisionEnter2D(Collision2D col) //oncollisionenter karakterle düşmanın birbirine temas anı
    // {
    //     if (col.gameObject.tag == "EnemyCastle") //eğer temas edenin tag'i player'sa
    //     {
    //         Debug.Log("SCORE +1");
    //         GameObject.Find("GameManager").GetComponent<GameManager>().player1Scored();
    //         Destroy(gameObject);
    //     }
    //     else if(col.gameObject.tag == "OurCastle")
    //     {
    //         Debug.Log("SKORE -1");
    //         GameObject.Find("GameManager").GetComponent<GameManager>().player2Scored();
    //         Destroy(gameObject);
    //     }
    // }
}
