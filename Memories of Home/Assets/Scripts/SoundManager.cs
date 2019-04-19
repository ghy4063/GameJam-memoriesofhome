using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioSource musicSource;
    public static SoundManager instance = null;

	// Use this for initialization
	void Awake () {
	    if (instance == null)
	        //if not, set it to this.
	        instance = this;
	    //If instance already exists:
	    else if (instance != this)
	        //Destroy this, this enforces our singleton pattern so there can only be one instance of SoundManager.
	        Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }


    public void PlaySingle(AudioClip clip)
    {
        sfxSource.clip = clip;

        sfxSource.Play();

    }
	// Update is called once per frame
	void Update () {
		
	}
}
