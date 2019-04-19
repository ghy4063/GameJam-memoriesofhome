using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    //bool to tell if it is paused or not
    private bool isPaused;
    // the game object the pause menu canvas is connected to
    public GameObject PMenu;
    // Use this for initialization
    void Start ()
    {
        isPaused = false;
    }
	
	// Update is called once per frame
	void Update () {
	    pauseMenutoggle();
    }
    void pauseMenutoggle()
    {
        //the input to pause the game 
        if (Input.GetKeyDown(KeyCode.P))
        {//checks to see if we are currently paused when P is pressed
            if (isPaused == false)
            {
                PMenu.SetActive(true);
                // activates the disabled pause menu and freezes time 
                Time.timeScale = 0f;
            }
            else
            {
                PMenu.SetActive(false);
                // reactivate the game by disabling the pause menu
                Time.timeScale = 1.0f;
            }

        }
    }
}
