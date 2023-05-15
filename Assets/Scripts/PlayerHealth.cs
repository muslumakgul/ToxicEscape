using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int _maxHealth = 10; //max canımız
    public int _health; //güncel can
    void Start()
    {
        _health = _maxHealth; //başlangıçta canımız güncel cana eşit
    }

    public void TakeDamage(int damage)
    {
        _health -= damage; //burayı tam anlamadım
        if (_health <= 0) //güncel canımız 0'a küçük eşitse
        {
            Destroy(gameObject); //bu objeyi yok et.
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
