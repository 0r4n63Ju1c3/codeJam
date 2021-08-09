using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(IntVariable))]
public class GameOverScript : MonoBehaviour
{
    public IntVariable playerScore;
    // Start is called before the first frame update
    void Start()
    {
        Transform child = transform.Find("ScoreText");
        child.GetComponent<Text>().text = "Score: " + playerScore.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
