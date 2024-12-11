using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveX;
    public float speed;


// Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<RigidBody2D>();
        moveX = Input.GetAxisraw("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
