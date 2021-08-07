using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PauseGame();
    }

    // Update is called once per frame
    void Update()
    {
        //Create button to resume game
        
    }

    void PauseGame() {
        Time.timeScale = 0;
    }

    void ResumeGame() {
        Time.timeScale = 1;
    }

}
