using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDoor : MonoBehaviour
{
    private bool isOpen = false; // Kapının açık veya kapalı olduğunu takip eden bir değişken
    public PlayAgain playAgain;
    public void LevelUpOpenDoor()
    {
        // Kapıyı aç
        // Örneğin, animasyon oynatılabilir veya kapı GameObject'inin etkinlik durumu değiştirilebilir
        // Bu örnekte, GameObject'in etkinlik durumu değiştiriliyor
        gameObject.SetActive(true);
        isOpen = true;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            playAgain.gotolevel3();
        }
    }

    public bool IsOpen()
    {
        return isOpen;
    }
}