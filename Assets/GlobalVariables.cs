using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public IntVariable lives;
    public IntVariable defaultLives;
    public IntVariable score;
    public IntVariable defaultScore;
    public IntVariable ballCount;
    public IntVariable defaultBallCount;
    public ListVariable ballList;
    public ListVariable defaultBallList;

    [SerializeField]
    private int currentLives;

    [SerializeField]
    private int currentScore;

    [SerializeField]
    private int currentBallCount;

    // Start is called before the first frame update
    void Start()
    {
        lives.value = defaultLives.value;
        score.value = defaultScore.value;
        ballCount.value = defaultBallCount.value;
        currentLives = lives.value;
        currentScore = score.value;
        currentBallCount = ballCount.value;

        ballList.list.Clear();

    }

    private void FixedUpdate()
    {
        currentLives = lives.value;
        currentScore = score.value;
        currentBallCount = ballCount.value;
    }
}
