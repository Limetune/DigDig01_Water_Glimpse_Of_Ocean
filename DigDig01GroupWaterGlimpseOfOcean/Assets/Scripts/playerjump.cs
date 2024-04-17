using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 10000000000000f;
    private float force = 30000000000000000000000f;
    float coolDown = 0.5f; // Adjust cooldown time as needed
    float nextTimeToJump = 0;
    bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && Time.time > nextTimeToJump && canJump)
        {
            nextTimeToJump = Time.time + coolDown;
            rb.AddForce(Vector2.up * rb.mass * force, ForceMode2D.Impulse);
            canJump = true; // Disable jumping until cooldown is over
        }
    }

    void FixedUpdate()
    {
        // Check if cooldown has elapsed, then allow jumping again
        if (!canJump && Time.time > nextTimeToJump)
        {
            canJump = true;
        }
    }
}
//  rb.AddForce(new Vector2(rb.velocity.x, jump));
//  public float jump;
/* private Rigidbody2D rb;
    public float speed = 10f;
    public float force = 300f;
    float coolDown = 3;
    float nextTimeToJump = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    bool jump = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        if (jump && nextTimeToJump < Time.time)
        {
            rb.AddForce(Vector2.up * rb.mass * force, ForceMode2D.Impulse);
            nextTimeToJump = Time.time + coolDown;
        }
    }
*/