using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayAgain : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LevelUp()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Minigame()
    {
        SceneManager.LoadScene("MiniGame");
    }
    
    public void gotolevel3()
    {
        SceneManager.LoadScene("Level3");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
