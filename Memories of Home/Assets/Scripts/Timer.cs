using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    //text that it grabs where it will display the remaining time
    public Text timerText;
    public float timeLeft;
	// amount of time you have to complete the objectives
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        //ticks down the time remaining
	    timeLeft -= Time.deltaTime;
        SetCountText();
        //when the timer hits 0 the game ends are is switched to the lose screen
	    if (timeLeft <= 0)
	    {
         SceneManager.LoadScene("LoseState");
	    }
	}

    void SetCountText()
    {//Displays the time remaining 
        timerText.text = "Seconds left: " + timeLeft.ToString();

    }
}
