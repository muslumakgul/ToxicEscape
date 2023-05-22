using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door; // Kapı GameObject referansı

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Anahtar alındığında kapıyı aç
            door.GetComponent<Door>().OpenDoor();
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
