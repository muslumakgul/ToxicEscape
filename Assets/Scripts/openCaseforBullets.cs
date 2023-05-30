using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openCaseforBullets : MonoBehaviour
{
    public PlayerController playerController;
    private float originalBullet;
    public PlayerBullet playerBullet;
    public int increaseBulletAmmo;
    public ShootScript shootScript;

    private bool canIncreaseBullet = false; // Mermi artırma durumunu kontrol etmek için

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            originalBullet = playerBullet.currentBulletAmount;
            canIncreaseBullet = true; // Kutuya değdiğinde mermi artırma durumunu aktif hale getir
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canIncreaseBullet = false; // Kutudan çıktığında mermi artırma durumunu pasif hale getir
        }
    }

    void Update()
    {
        if (canIncreaseBullet && Input.GetKeyDown(KeyCode.E))
        {
            IncreaseBulletAmmo(); // Kutuya değildiğinde ve E tuşuna bastığında mermi sayısını artır
        }
    }

    void IncreaseBulletAmmo()
    {
        playerBullet.currentBulletAmount += increaseBulletAmmo; // Mermi sayısını artır
        shootScript.setMaxBulletAmount = playerBullet.currentBulletAmount; // shootScript'te mermi sayısını güncelle
        playerBullet.bulletBar.SetMaxBulletAmount(playerBullet.currentBulletAmount); // Mermi çubuğunun maksimum değerini güncelle
        playerBullet.bulletBar.setBulletAmount(playerBullet.currentBulletAmount); // Mermi çubuğunu güncelle
        
    }
}