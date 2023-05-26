using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10; //max canımız
    public int currentHealth; //güncel can
    public PlayAgain playagain;
    public HealthBarScript healthBar;
    //public PlayAgain playAgain;
    public AudioScript audioScript; 
    
    
    void Start()
    {
        currentHealth = maxHealth; //başlangıçta canımız güncel cana eşit
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; //mevcut canımızı damage oranında azaltıyor.
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0) //güncel canımız 0'a küçük eşitse
        {
            Destroy(gameObject); //bu objeyi yok et.
            audioScript.PlayGameOverSound();
            playagain.GotoMainMenu();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            TakeDamage(2);
        }
    }
}
