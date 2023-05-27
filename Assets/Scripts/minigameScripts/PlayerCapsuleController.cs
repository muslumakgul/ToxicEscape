using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCapsuleController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, speed);
        }
        // S tuşuna basılı tutulduğunda aşağı yönde hareket
        else if (Input.GetKey(KeyCode.S))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, -speed);
        }
        // Hiçbir tuşa basılmadığında veya tuşlar bırakıldığında hareketsiz dur
        else
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
