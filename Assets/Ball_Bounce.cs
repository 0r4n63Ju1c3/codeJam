using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Bounce : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(speed, Random.Range(3, 10));
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
