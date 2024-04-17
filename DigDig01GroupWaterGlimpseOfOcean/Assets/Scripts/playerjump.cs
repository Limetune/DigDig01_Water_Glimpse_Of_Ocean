using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10f;
    public float force = 300f;
   
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
        if (jump)
        {
            rb.AddForce(Vector2.up * rb.mass * force, ForceMode2D.Impulse);
            
        }
    }
}
//  rb.AddForce(new Vector2(rb.velocity.x, jump));
//  public float jump;