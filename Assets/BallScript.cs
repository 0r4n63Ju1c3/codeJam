using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    protected Rigidbody2D rb;
    public float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Ball velocity should be determined by launcher
        rb.velocity = new Vector2(transform.right.x, transform.right.y);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = speed*rb.velocity.normalized;
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());        
        }
    }*/
}
