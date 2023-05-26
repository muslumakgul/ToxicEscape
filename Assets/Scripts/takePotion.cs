using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takePotion : MonoBehaviour
{
    public PlayerController playercontroller;
    
    private bool isSpeedIncreased = false; // Hızın arttırılıp artırılmadığını tutan flag
    private float originalSpeed; // Orijinal hız değerini saklamak için değişken
    public float speedIncreaseAmount; // Hızın artış miktarı
    public float speedIncreaseDuration; // Hız artışının süresi

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isSpeedIncreased)
        {
            // Anahtar alındığında hızı arttır
            originalSpeed = playercontroller.speed; // Orijinal hızı sakla
            playercontroller.speed += speedIncreaseAmount; // Hızı arttır
            isSpeedIncreased = true; // Hızın arttırıldığını işaretle
    
            // Belirli bir süre bekleyip eski hıza geri dön
            Invoke("ResetSpeed", speedIncreaseDuration);
    
            // Anahtar GameObject'i pasif yap
            gameObject.SetActive(false);
        }
    }

    private void ResetSpeed()
    {
        // Hızı eski hızına geri döndür
        playercontroller.speed = originalSpeed;
        isSpeedIncreased = false; // Hız artışının sona erdiğini işaretle
    
        // Anahtar GameObject'i aktif yap (tekrar kullanılabilir hale getir)
        //gameObject.SetActive(true);
    }

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
