﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnStartButtonClick() {
		SceneManager.LoadScene("GameScene");
	}

	public void OnQuitButtonClick() {
		Application.Quit();
	}

}
