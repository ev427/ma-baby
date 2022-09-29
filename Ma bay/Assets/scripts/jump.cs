using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float moveSpeed = 10;
    public float jumpSpeed = 20;

    public bool isOnGround;

    private Rigidbody2D _myRB;
    private Collider2D _myCollider;

    void Start()
    {
        _myRB = GetComponent<Rigidbody2D>();
        _myCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        _myRB.velocity = new Vector2(horizontalInput * moveSpeed, _myRB.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            _myRB.velocity = new Vector2(_myRB.velocity.x, jumpSpeed);
        }
    }
}
