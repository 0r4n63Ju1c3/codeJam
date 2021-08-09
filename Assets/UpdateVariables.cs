using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateVariables : MonoBehaviour
{
    public IntVariable playerScore;
    public IntVariable playerLives;
    public Canvas scoreboard;

    [SerializeField]
    private int score;
    private int lives;

    // Start is called before the first frame update
    void Start()
    {
        score = playerScore.value;
        lives = playerLives.value;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScore.value != score)
        {
            //GameObject.Find is slow. Look to find better solution.
            Transform scoreText = transform.Find("Score");
            scoreText.GetComponent<Text>().text = "Score: " + playerScore.value;
            score = playerScore.value;
        }

        if(playerLives.value != lives)
        {
            Transform livesText = transform.Find("Lives");
            livesText.GetComponent<Text>().text = "Lives: " + playerLives.value;
            lives = playerLives.value;

        }
    }
}
