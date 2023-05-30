using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.SceneManagement;
public class ComputerToMiniGame : MonoBehaviour
{
    public PlayAgain playAgain;
    private Vector3 playerStartPosition;
    private int playerScore;
    private int _currentPlayerhealth;
    public CoinCounter coinCounter;
    public PlayerHealth playerHealth;
    // private void Start()
    // {
    //     playerStartPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    //     playerScore = coinCounter.scoreNum;
    //     _currentPlayerhealth = playerHealth.currentHealth;
    // }

    //public string MiniGame; // Minigame sahnesinin adı
    //public LevelManager levelmanager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playAgain.Minigame();
        }
    }
}
