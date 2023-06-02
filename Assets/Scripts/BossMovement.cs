using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public Transform player; // Oyuncu nesnesinin referansı
    public float movementSpeed = 5f; // Düşmanın hareket hızı
    public float detectionRange = 10f; // Oyuncunun algılama mesafesi
    public int damage;
    public PlayerHealth playerHealth;
    public AudioScript audioScript;
    public EnemyManager enemyManager;
    public int MaxHealth;
    public int currentHealth;

    // public float retreatDistance = 2f; // Geri çekilme mesafesi
    //
    // private bool isRetreating = false; // Geri çekilme durumu
    //
    // private Vector2 retreatDirection; // Geri çekilme yönü
    private void Start()
    {
        currentHealth = MaxHealth;
        enemyManager = GameObject.FindObjectOfType<EnemyManager>();
        
    }
    private void Update()
    {
        // Oyuncunun düşmanın algılama mesafesinde olup olmadığını kontrol et
        if (Vector2.Distance(transform.position, player.position) <= detectionRange)
        {
                // Düşmanı oyuncuya doğru hareket ettir
                Vector2 direction = player.position - transform.position;
                transform.Translate(direction.normalized * (movementSpeed * Time.deltaTime));
            
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D col) //oncollisionenter karakterle düşmanın birbirine temas anı
    {
        if (col.gameObject.tag == "Player") //eğer temas edenin tag'i player'sa
        {
            playerHealth.TakeDamage(damage);    //diğer scriptteki damage fonksiyonunu çalıştır
            audioScript.PlayDamageSound();  //diğer scriptteki damage sesi fonksiyonunu çalıştır
            
            // Geri çekilme yönünü hesapla (düşmanın oyuncudan uzaklaşması için)
            // retreatDirection = transform.position - player.position;
            // isRetreating = true;
        }

        if ((col.gameObject.tag == "Bullet"))
        {
            enemyManager.CheckEnemiesDestroyed();
            currentHealth--;
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
            // enemyManager.EnemyDestroyed();
        }
    }
    
}
