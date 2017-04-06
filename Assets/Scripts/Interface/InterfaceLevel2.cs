using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InterfaceLevel2 : MonoBehaviour {

	public Text textThrown;
	public Text textDestroyed;
	public Text textLives;
	public bool pause;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		textThrown.text = "Number of Stones: " + GameManager.currentNumberStonesThrown;
		textDestroyed.text = "Destroyed: " + GameManager.currentNumberDestroyedStones;
		textLives.text = "Lives: " + GameManager.lives;
	}

	public void Pause(){
		if (pause) {
			Time.timeScale = 0;
			pause = false;
		} else {
			Time.timeScale = 3;
			pause = true;
		}
	}
}
