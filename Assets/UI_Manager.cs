using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
        ScanForKeyStroke();
    }
    void ScanForKeyStroke()
    {
        var kb = Keyboard.current;
        if (kb.escapeKey.wasPressedThisFrame){
            GM.TogglePauseMenu();
        }
    } 
}
