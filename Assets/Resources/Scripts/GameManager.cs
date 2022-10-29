using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject playerCharacter;
    [SerializeField] private GameObject levelSpawn;
    
    void Start()
    {
        Vector3 position = levelSpawn.transform.position;
        position.y = 0.25f;

        playerCharacter.transform.position = position;
    }

    void Update()
    {
        //Toggles screen mode
        if (Input.GetKeyDown(KeyCode.F11))
        {
            FullScreenMode currentScreenMode = Screen.fullScreenMode;

            //If it is at the fullscreen mode, then it should switch back to windowed mode
            if ((currentScreenMode != FullScreenMode.Windowed) && (currentScreenMode != FullScreenMode.MaximizedWindow))
            {
                Screen.fullScreenMode = FullScreenMode.Windowed;
            }
            //If it is at the windowed mode, then it should switch to fullscreen mode
            else
            {
                Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
            }
        }
        //Exits the game
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
