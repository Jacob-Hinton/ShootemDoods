using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/****************************************************************************************/
/*
/* FILE NAME: life_counter
/*
/* DESCRIPTION: this script manages the total life count of the player ship
 * 				and is maintained over all levels
/*
/*
/* DATE     BY     			  DESCRIPTION
/* ======== ======= 		  =============
/* 11/27/16 Jacob			  created script
/*
/****************************************************************************************/


public class life_counter : MonoBehaviour {

	public static int lives = 3;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

	public static void increaseLife() {
		if (lives < 3)
			lives++;
	}

	public static void decreaseLife() {
		if (lives > 0) {
			lives--;
			Scene scene = SceneManager.GetActiveScene();

			SceneManager.LoadScene(scene.name);
		}
		else {
			pause_script.Pause();
			pause_script.gameOver();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
