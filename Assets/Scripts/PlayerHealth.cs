using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10; //max canımız
    public int currentHealth; //güncel can

    public HealthBarScript healthBar;



    void Start()
    {
        currentHealth = maxHealth; //başlangıçta canımız güncel cana eşit
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; //burayı tam anlamadım
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0) //güncel canımız 0'a küçük eşitse
        {
            Destroy(gameObject); //bu objeyi yok et.
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
