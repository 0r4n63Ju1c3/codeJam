using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZoneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public IntVariable playerScore;
    public IntVariable ballCount;
    public ListVariable ballList;
    void Start()
    {
        
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
            playerScore.value += ballCount.value * 100 / 2;
            ballCount.value--;
        }

    }
}
