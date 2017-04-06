using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InterfaceSettings : MonoBehaviour {

	public Slider volumeSlider;
	public Button volumeButton;
	public bool muteOn = true;
	public GameObject speakerImage;
	public GameObject muteImage;

	// Use this for initialization
	void Start () {
		volumeSlider.value = GameManager.volume;
		speakerImage = GameObject.Find ("RawImageSpeaker");
		muteImage = GameObject.Find ("RawImageMute");
		speakerImage.SetActive (true);
		muteImage.SetActive (false);
		AudioListener.volume = volumeSlider.normalizedValue;
		GameManager.volume = volumeSlider.normalizedValue;
	}
	
	// Update is called once per frame
	void Update () {
		if (!muteOn) {
			AudioListener.volume = volumeSlider.normalizedValue;
			speakerImage.SetActive (true);
			muteImage.SetActive (false);
		} else {
			speakerImage.SetActive (false);
			muteImage.SetActive (true);
		}
		GameManager.volume = volumeSlider.normalizedValue;
//		if (volumeSlider.normalizedValue == 0) {
//			speakerImage.SetActive (false);
//			muteImage.SetActive (true);
//		}
	}

	public void back(){
		SceneManager.LoadScene ("Awake");
	}

	public void muteButton(){
		if (muteOn && volumeSlider.value != 0) {
			print ("Case muteON = " + muteOn);
			AudioListener.volume = GameManager.volume;
			speakerImage.SetActive (true);
			muteImage.SetActive (false);
			volumeSlider.value = GameManager.volume;
			muteOn = false;
		} else {
			print ("Case muteON = " + muteOn);
			AudioListener.volume = 0;
			speakerImage.SetActive (false);
			muteImage.SetActive (true);
			volumeSlider.value = 0;
			muteOn = true;
		}

	}
}
