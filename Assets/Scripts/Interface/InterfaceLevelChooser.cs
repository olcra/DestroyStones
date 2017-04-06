using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceLevelChooser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void back(){
		SceneManager.LoadScene ("Awake");
	}
	public void level1(){
		SceneManager.LoadScene("Level1");
	}
	public void level2(){
		SceneManager.LoadScene("Level2");
	}
	public void level3(){
		SceneManager.LoadScene("Level3");
	}
	public void level4(){
		SceneManager.LoadScene("Level4");
	}
	public void level5(){
		SceneManager.LoadScene("Level5");
	}
	public void level6(){
		SceneManager.LoadScene("Level6");
	}
	public void level7(){
		SceneManager.LoadScene("Level7");
	}


}
