using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(IntVariable))]
[RequireComponent(typeof(ListVariable))]
public class DangerZoneScript : MonoBehaviour
{

    public IntVariable lives;
    public IntVariable ballCount;
    public ListVariable ballList;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Dangerzone is awake");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            ballList.list.Remove(other.gameObject);
            Destroy(other.gameObject);
            lives.value--;
            ballCount.value--;
        }

        if(lives.value <= 0)
        {
            Cursor.visible = true;
            SceneManager.LoadScene(2);
        }
            
    }
}
