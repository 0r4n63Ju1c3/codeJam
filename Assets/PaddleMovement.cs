using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class PaddleMovement : MonoBehaviour
{

    /*private Vector3 mousePosition;*/
    private Vector2 lastPosition;
    private Rigidbody2D rb;
    public float moveSpeed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        /*Cursor.lockState = CursorLockMode.Confined;*/
        lastPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        var mouse = Mouse.current;
        if (mouse.rightButton.isPressed)
        {
            Vector2 screenCenter = new Vector2(Screen.width / 2.0f, Screen.height / 2.0f);

            /*mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);*/

            Vector2 mousePosition = mouse.position.ReadValue();
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Vector2 centerPosition = Camera.main.ScreenToWorldPoint(screenCenter);

            Vector2 deltaPosition = mousePosition - centerPosition;

            Vector2 mouseVelocity = deltaPosition / Time.deltaTime;

            rb.velocity = mouseVelocity;
            
            mouse.WarpCursorPosition(screenCenter);
            //InputState.Change(mouse.position, screenCenter);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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