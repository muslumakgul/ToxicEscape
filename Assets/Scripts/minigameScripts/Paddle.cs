using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    public float AIspeed;
    private Vector2 _forwardDirection;
    private float _movement;
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallMovement>();
        if (isAI)
        {
             _forwardDirection = Vector2.left;
        }

        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            _movement = Input.GetAxisRaw("Vertical2");
        }
        else
        {
            _movement = Input.GetAxisRaw("Debug Horizontal");
        }

        if (isAI)
        {
            float targetYposition = GetNewYPosition();
            transform.position = new Vector3(transform.position.x, targetYposition, transform.position.z);
        }
        
        
        rb.velocity = new Vector2(rb.velocity.x, _movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
    
    
    //AI

    public bool isAI;
    private BallMovement ball;

    private float GetNewYPosition()
    {
        float result = transform.position.y;
        if (isAI)
        {
            if (BallIncoming())
            {
                result = Mathf.MoveTowards(transform.position.y, ball.transform.position.y, AIspeed * Time.deltaTime);
            }
        }
        else
        {
            result = transform.position.y + _movement;
        }

        return result;
        }

    private bool BallIncoming()
    {
        float dotP = Vector2.Dot(ball.rb.velocity, _forwardDirection);
        return dotP < 0f;
    }
}
