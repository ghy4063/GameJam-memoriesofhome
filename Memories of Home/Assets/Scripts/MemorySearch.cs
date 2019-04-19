using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MemorySearch : MonoBehaviour
{
    [Header("Text Areas for the item counts")]
    //public Text speicalCountText;
    public Text memoryCountText;

    public int ScoreToWin;
    public AudioClip pickup;
    public AudioClip AlertAudioClip;
    private int memoryCount;
   // private int specialCount;
	// Use this for initialization
	void Start ()
	{
	    gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
        memoryCount = 0;
	   // specialCount = 0;
		SetMemoryCountText();
        SetSpecialCountText();
	    //sr = GetComponentInChildren<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        //win condition for the game 
	    if (memoryCount == ScoreToWin)
	    {
            SceneManager.LoadScene("WinState");

	    }
	   
    }
    //when the player enters a trigger area for a memory
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Memory")
        {//turns on the yellow indicator when you are near a memory
            gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
            SoundManager.instance.PlaySingle(AlertAudioClip);
            //press space to collect
            if (Input.GetKeyDown(KeyCode.Space))
            {//checks to see if the area actually has a memory to collect

                if (other.gameObject.GetComponent<Memories>() != null)
                {SoundManager.instance.PlaySingle(pickup);
                    Debug.Log("found a memory");
                    memoryCount = memoryCount + 1;
                    SetMemoryCountText();//turns off the indicator and adds one to the count
                    other.gameObject.GetComponent<Collider>().enabled = false;
                }
                else
                {
                    Debug.Log("No memory here");//returns that there was no memory here
                    gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
                    other.gameObject.GetComponent<Collider>().enabled = false;
                }

            }

        }


    }
    
    //displays the amount of memories you have
    void SetMemoryCountText()
    {
         gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
         memoryCountText.text = "Memory Count: " + memoryCount.ToString();
    }

    void SetSpecialCountText()
    {
       // specialCountText.text = "AI Count: " + specialCount.ToString();
    }
}
