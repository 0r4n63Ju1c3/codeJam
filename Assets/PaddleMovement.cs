using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class PaddleMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        /*Cursor.lockState = CursorLockMode.Confined;*/
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        var mouse = Mouse.current;
        Cursor.visible = false;

        Vector3 screenCenter = new Vector3(Screen.width / 2.0f, Screen.height / 2.0f, 0.0f);
        Vector2 centerPosition = Camera.main.ScreenToWorldPoint(screenCenter);

        Vector2 deltaScreenPosition = mouse.position.ReadValue();
        Vector3 deltaCamera = Camera.main.ScreenToWorldPoint(new Vector3(deltaScreenPosition.x, deltaScreenPosition.y, 0.0f));
        Vector2 deltaPosition = new Vector2(deltaCamera.x, deltaCamera.y);
            

        rb.velocity = (deltaPosition - centerPosition) / Time.deltaTime;

        mouse.WarpCursorPosition(new Vector2(screenCenter.x, screenCenter.y));
        InputState.Change(mouse.position, new Vector2(screenCenter.x, screenCenter.y));

        /*
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(mouse.position.ReadValue());
        Vector3 centerPosition = Camera.main.ScreenToWorldPoint(screenCenter);
        Vector2 returnPosition = new Vector2(centerPosition.x, centerPosition.y);
        Vector2 deltaPosition = mousePosition - returnPosition;
        Vector2 mouseVelocity = deltaPosition / Time.deltaTime;
        rb.velocity = mouseVelocity;
            
        */
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