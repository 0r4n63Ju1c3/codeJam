using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherScript : MonoBehaviour
{
    public GameObject ballPrefab;
    private float timer = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if(timer <= 0.0f)
        {
            Instantiate(ballPrefab, transform.position, transform.rotation);
            timer = 2.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
