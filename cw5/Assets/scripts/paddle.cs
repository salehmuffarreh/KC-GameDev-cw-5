using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    Rigidbody2D RB;
    float Playerinput;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        speed = 20f;

    }

    private void FixedUpdate()
    {
        move();
    }

    void move()
    {
        Playerinput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(Playerinput * speed, 0);

    }

    private void onTriggerEnter2D(Collider2D collision)
    {
        print("collision detected");

    }

}   
    