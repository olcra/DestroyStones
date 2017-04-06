using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameManager.currentNumberStonesThrown = 0;
		GameManager.currentNumberDestroyedStones = 0;
		GameManager.lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void clickStory(){
		//Application.load ("stoneGame");
		SceneManager.LoadScene ("LevelChooser");
	}
	public void clickTimeAttack(){
		SceneManager.LoadScene ("TimeAttack");
	}

	public void clickArcade(){
		SceneManager.LoadScene ("Arcade");
	}
	public void clickSettings(){
		SceneManager.LoadScene ("Settings");
	}


}
