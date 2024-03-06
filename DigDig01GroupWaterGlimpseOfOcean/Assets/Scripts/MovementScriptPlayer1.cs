using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerMovementScriptPlayer1 : MonoBehaviour
{

    public float movementspeed;
    public Rigidbody2D rb;
    Vector2 moveDirection;
    bool lookRight = true;

    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 24f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;

    // Update is called once per frame
    void Update()
    {
        float moveX = 0;
        float moveY = 0;

        if (isDashing)
        {
            return;
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }
        moveDirection = new Vector2(moveX, moveY).normalized;
        Flip(moveX);
    }
    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
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

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower,
                                  0f);
        yield return new WaitForSeconds(dashingTime);
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }

}
