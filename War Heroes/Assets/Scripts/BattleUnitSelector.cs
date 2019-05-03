using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleUnitSelector : MonoBehaviour {

	Scene currentScene;
 	string sceneName;

	//void OnButtonPressed()
	//{
		//if (sceneName == "BattleGround")
			//if (this.gameObject.name == "ros1")
				
	// Use this for initialization
	void Start () {
		sceneName = currentScene.name;
		currentScene = SceneManager.GetActiveScene ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
