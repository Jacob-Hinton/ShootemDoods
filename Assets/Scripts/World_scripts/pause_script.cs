using UnityEngine;
using System.Collections;
/****************************************************************************************/
/*
/* FILE NAME: pause_script
/*
/* DESCRIPTION: this conatains the functionality for the pause menu
/*
/*
/* DATE     BY     		DESCRIPTION
/* ======== ======= 	=============
/* 10/25/16 Jacob		created script
/*
/****************************************************************************************/

public class pause_script : MonoBehaviour {

	public static bool isPause = false;
	public Rect pauseRect = new Rect(120, 50, 120, 50);

	Rect centerRectangle (Rect someRect)
	{
		someRect.x = ( Screen.width  - someRect.width ) / 2;
		someRect.y = ( Screen.height - someRect.height ) / 2;


		return someRect;

	}

	void Start() {
		pauseRect = centerRectangle(pauseRect);
	}

	void Update () {
		if( Input.GetKeyDown(KeyCode.Escape))
		{
			isPause = !isPause;
			if (isPause) {
				Time.timeScale = 0;
			} else {
				Time.timeScale = 1;
			}
		}
	}

	void OnGUI() {
		if(isPause)
			GUI.Window(0, pauseRect, DoMyWindow, "Pause Menu");
	}

	void DoMyWindow(int windowID) {
		if (GUI.Button (new Rect (10, 20, 100, 20), "Resume")) {
			isPause = !isPause;
			Time.timeScale = 1;
		} 
		if (GUI.Button (new Rect (10, 40, 100, 20), "Controls")) {
			//implement this upon having a picture of controls available
		} 
		if (GUI.Button (new Rect (10, 60, 100, 20), "Quit")) {
			//implement this upon having a start menu
		}

	}
}
