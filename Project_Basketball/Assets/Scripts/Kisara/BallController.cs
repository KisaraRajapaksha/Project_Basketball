using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private GameObject ball;
    private Rigidbody2D ballRb;
    [SerializeField] float force;
    
    void Awake()
    {
        ball = this.gameObject;
        ballRb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            ballRb.AddForce(new Vector2(0,force), ForceMode2D.Impulse);
        }
    }
}
