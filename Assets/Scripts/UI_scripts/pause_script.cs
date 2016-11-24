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


	void Start() {
	}

    public bool getIsPause()
    {
        return isPause;
    }

    public static void unPause()
    {
        isPause = false;
    }

	void Update () {
        if (isPause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        if ( Input.GetKeyDown(KeyCode.Escape)|| Input.GetButtonDown("Start Button"))
		{
			isPause = !isPause;
			
		}
	}

}
