using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ScanForKeyStroke()
    {
        if (Input.GetKeyDown("escape")){
            GM.TogglePauseMenu();
    }
}
}
