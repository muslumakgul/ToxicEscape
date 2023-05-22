using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage; //vuracağı damage . karakterin düşüreceği can yani
    public PlayerHealth playerHealth; //diğer scriptle bağladık referans
    // public EnemyManager enemyManager; 
    
    private void OnCollisionEnter2D(Collision2D col) //oncollisionenter karakterle düşmanın birbirine temas anı
    {
        if (col.gameObject.tag == "Player") //eğer temas edenin tag'i player'sa
        {
            playerHealth.TakeDamage(damage);    //diğer scriptteki damage fonksiyonunu çalıştır
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
