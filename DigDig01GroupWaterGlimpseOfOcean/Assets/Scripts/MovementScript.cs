using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public float movementspeed;
    public Rigidbody2D rb;
    Vector2 moveDirection;

    bool lookRight = true;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
        Flip(moveX);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * movementspeed, moveDirection.y * movementspeed);
    }
    void Flip(float moveX)
    {
        if ((moveX > 0 && lookRight == false) || (moveX < 0 && lookRight == true))
        {
            transform.Rotate(0f, 180f, 0f);
            lookRight = !lookRight;
        }
    }
}
