using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
[RequireComponent(typeof(IntVariable))]
[RequireComponent(typeof(ListVariable))]
public class LauncherScript : MonoBehaviour
{
    public GameObject ballPrefab;

    public IntVariable ballCount;

    public IntVariable playerScore;

    public ListVariable ballList;

    [SerializeField]
    private int currentBallCount;

    private float timer = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentBallCount = ballCount.value;
        
    }

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0.0f)
        {
            ballCount.value++;
            currentBallCount++;
            Quaternion rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(180, transform.forward), Random.Range(0.2f, 0.8f));
            GameObject ball = Instantiate(ballPrefab, transform.position, rotation);
            if((playerScore.value / 5000.0f) + 1 < 2.0f)
            {
                ball.GetComponent<BallScript>().speed *= (playerScore.value / 5000.0f) + 1;
            }
            else
            {
                ball.GetComponent<BallScript>().speed *= 2.4f;
            }
            
            /*foreach(GameObject b in ballList.list)
            {
                Physics2D.IgnoreCollision(b.GetComponent<Collider2D>(), ball.GetComponent<Collider2D>());
            }*/
            ballList.list.Add(ball);

            timer = 5.0f;
        }
    }
}
