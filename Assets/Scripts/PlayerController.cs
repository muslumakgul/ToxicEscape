using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    private Vector2 _movement;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _sr = gameObject.GetComponent<SpriteRenderer>();
        //bu kodu atacağım objenin (gameObject) içindeki rigibody2d ve spriterendererının componentine ulaş.
    }
    void Update()
    {
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = Input.GetAxis("Vertical");
        
        //x ve y yönünde hareket edeceğim için unity içinde hazır tanımlanmış horizontal ve vertical değerlerine eşitledim
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movement * (speed * Time.deltaTime));
        // rigibodyim hareketinin değerlerini burada belirttim. 
        if (_movement.x < 0) //eğer x yönündeki hareketimin değeri 0'dan küçükse yani sola doğru ise
        {
            _sr.flipX = false; //sprite renderırımın içindeki flipx boolunu false yap
        }
        else if (_movement.x > 0)
        {
            _sr.flipX = true; //sprite renderırımın içindeki flipx boolunu true yap
        }
        
        //normalde bu false ve true tam tersi şeklinde olmalıydı. ama karakterimizin default duruşu sola doğru olduğu için tersini yaptık.
    }
}
