using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(IntVariable))]
public class GlobalVariables : MonoBehaviour
{
    public IntVariable lives;
    public IntVariable defaultLives;
    public IntVariable score;
    public IntVariable defaultScore;

    [SerializeField]
    private int currentLives;

    [SerializeField]
    private int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        lives.value = defaultLives.value;
        score.value = defaultScore.value;
        currentLives = lives.value;
        currentScore = score.value;
    }

    private void FixedUpdate()
    {
        currentLives = lives.value;
    }
}
