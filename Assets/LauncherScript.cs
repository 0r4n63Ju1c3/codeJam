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
            Quaternion rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(180, transform.forward), Random.value);
            Debug.Log(rotation.ToString());
            Instantiate(ballPrefab, transform.position, rotation);
            timer = 2.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
