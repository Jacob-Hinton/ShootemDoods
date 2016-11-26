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
 * 11/23/16 Brandon     added unPause()
 * 11/24/16 Brandon     added game over functionality
/*
/****************************************************************************************/

public class pause_script : MonoBehaviour {

	public static bool isPause = false;
    public static bool isGameOver = false;
    public Canvas gameOverScreen;


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

    public static void gameOver()
    {
        isGameOver = true;
    }

    public static void Pause()
    {
        isPause = true;
    }

    void Update () {
        if (isGameOver)
        {
            gameOverScreen.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
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
