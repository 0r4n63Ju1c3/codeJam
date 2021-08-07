using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    private Vector3 mousePosition;
    private Vector2 lastPosition;
    private Rigidbody2D rb;
    public float moveSpeed = 0.1f;

    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        lastPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(1))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            /* 
            Vector2 tempPosition = new Vector2(mousePosition.x ,transform.position.y);
            lastPosition = transform.position;
            transform.position = Vector2.Lerp(transform.position, tempPosition, moveSpeed);*/

            float deltaPosition = mousePosition.x - lastPosition.x;
            Vector2 mouseVelocity = new Vector2(deltaPosition / Time.deltaTime, 0f);
            rb.velocity = mouseVelocity;
            lastPosition = mousePosition;

            




        }
    }
    void OnCollisionEnter2D(Collision2D paddle)
    {
        
        if (paddle.gameObject.tag == "Wall")
        {
            Debug.Log("Kill Me");
            rb.velocity = Vector2.zero;
            /*transform.position = lastPosition;*/
        }
    }
}
