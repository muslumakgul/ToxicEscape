using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D _rb;
    private Animator _anim;
    private Transform _currentPoint;
    public float speed;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _currentPoint = pointB.transform;
        _anim.SetBool("isRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = _currentPoint.position - transform.position;
        if (_currentPoint == pointB.transform)
        {
            _rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            _rb.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, _currentPoint.position) < 0.5f && _currentPoint == pointB.transform)
        {
            flip();
            _currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, _currentPoint.position) < 0.5f && _currentPoint == pointA.transform)
        {
            flip();
            _currentPoint = pointB.transform;
        }
    }

    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }
}
