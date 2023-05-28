using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyforlevel1 : MonoBehaviour
{
    public GameObject door; // Kapı GameObject referansı
    public AudioScript audioScript;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioScript.PlayKeySound();
            // Anahtar alındığında kapıyı aç
            door.GetComponent<leveldoorforlevel1>().levelUp();
            // Anahtar GameObject'i yok et
            Destroy(gameObject);
        }
    }
    
    public void PickupKey()
    {
        // Anahtarın alındığında yapılması gereken işlemler
        Debug.Log("Anahtar alındı!");
    }
}