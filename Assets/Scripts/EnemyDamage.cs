using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage; //vuracağı damage . karakterin düşüreceği can yani
    public PlayerHealth playerHealth; //diğer scriptle bağladık referans
    // public EnemyManager enemyManager; 
    public AudioScript audioScript;
    
    private void OnCollisionEnter2D(Collision2D col) //oncollisionenter karakterle düşmanın birbirine temas anı
    {
        if (col.gameObject.tag == "Player") //eğer temas edenin tag'i player'sa
        {
            playerHealth.TakeDamage(damage);    //diğer scriptteki damage fonksiyonunu çalıştır
            audioScript.PlayDamageSound();  //diğer scriptteki damage sesi fonksiyonunu çalıştır
        }

        if ((col.gameObject.tag == "Bullet"))
        {
            Destroy(gameObject);
            // enemyManager.EnemyDestroyed();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
