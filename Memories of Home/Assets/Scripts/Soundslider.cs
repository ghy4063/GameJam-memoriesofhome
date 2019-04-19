using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Soundslider : MonoBehaviour {
    public Slider volumeSlider;
    public AudioSource volumeAudio;
    public void VolumeController()
    {
          volumeAudio.volume= volumeSlider.value;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
