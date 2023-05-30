using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private Vector3 playerStartPosition;

    private void Start()
    {
        playerStartPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    public void SaveGame()
    {
        // Oyun durumunu kaydetmek için PlayerPrefs kullanın
        PlayerPrefs.SetInt("PlayerScore", 100);
        PlayerPrefs.SetFloat("PlayerXPosition", playerStartPosition.x);
        PlayerPrefs.SetFloat("PlayerYPosition", playerStartPosition.y);
        PlayerPrefs.SetFloat("PlayerZPosition", playerStartPosition.z);
    }

    public void LoadGame()
    {
        // Kaydedilen oyun durumunu yüklemek için PlayerPrefs kullanın
        int score = PlayerPrefs.GetInt("PlayerScore");
        float xPosition = PlayerPrefs.GetFloat("PlayerXPosition");
        float yPosition = PlayerPrefs.GetFloat("PlayerYPosition");
        float zPosition = PlayerPrefs.GetFloat("PlayerZPosition");

        Vector3 playerPosition = new Vector3(xPosition, yPosition, zPosition);
        // Oyun durumunu ve pozisyonunu kullanarak oyunu devam ettirin
    }

    public void ReturnToLevel1()
    {
        SceneManager.LoadScene("Level1");
        LoadGame();
    }
}