using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    public float startSpeed = 5f; // Başlangıç hızı
    public Vector3 startPosition;
    public Rigidbody2D rb;
    //private Vector2 initialVelocity; // Başlangıçtaki hızı tutmak için
    //private bool isMovingRight = true; // Topun başlangıçta sağa doğru hareket ettiğini belirtmek için

    private void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(startSpeed * x, startSpeed * y);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }
    // private void Start()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    //
    //     // Başlangıçta sağa doğru hareket etmek için hızı ayarla
    //     rb.velocity = new Vector2(startSpeed, 0f);
    //
    //     initialVelocity = rb.velocity; // Başlangıçtaki hızı kaydet
    // }
    //
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Capsule"))
    //     {
    //         if (isMovingRight)
    //         {
    //             rb.velocity = -initialVelocity; // Capsül topa çarptığında hareket yönünü tersine çevir
    //             isMovingRight = false; // Top artık sola doğru hareket edecek
    //         }
    //         else
    //         {
    //             rb.velocity = initialVelocity; // Capsül topa çarptığında hareket yönünü tersine çevir
    //             isMovingRight = true; // Top artık sağa doğru hareket edecek
    //         }
    //     }
    // }
}
