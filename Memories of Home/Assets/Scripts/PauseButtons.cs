using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseButtons : MonoBehaviour
{
    //grabs the script on the player to make sure it can call it
    public PauseMenu Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //quit button that when pressed exits the application
    public void quitButton()
    {
        Application.Quit();

    }

    //resumes game by making the deactivating Pmenu in pause menu
    public void resumeButton()
    {
        Player.PMenu.SetActive(false);
        Time.timeScale = 1.0f;

    }

    //loads the main menu when pressed
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");

    }
}
