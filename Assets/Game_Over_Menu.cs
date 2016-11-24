using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/****************************************************************************************/
/*
/* FILE NAME: Game_Over_Menu
/*
/* DESCRIPTION: this script controls the behavior of the on-screen game over menu.
/*
/*
/* DATE     BY     			  DESCRIPTION
/* ======== ======= 		  =============
/* 11/24/16 Brandon           created script
/*
/****************************************************************************************/

public class Game_Over_Menu : MonoBehaviour {
    public int state = 0;
    private bool canScroll = true;
    public Canvas switch1;
    public Canvas switch2;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (pause_script.isGameOver)
        {
            if (((Input.GetKeyDown(KeyCode.W) || ((Input.GetAxis("Vertical")) > 0 && canScroll))) && state > 0)
            {
                state--;
                canScroll = false;
            }
            else if (((Input.GetKeyDown(KeyCode.S) || ((Input.GetAxis("Vertical")) < 0 && canScroll))) && state < 1)
            {
                state++;
                canScroll = false;
            }

            if (Input.GetAxis("Vertical") == 0)
            {
                canScroll = true;
            }

            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1")))
            {
                select();
            }

            if (state == 0) //highlight "Start"
            {
                switch1.GetComponent<CanvasGroup>().alpha = 1.0F;
            }
            else
            {
                switch1.GetComponent<CanvasGroup>().alpha = 0.0F;
            }
            if (state == 1) //Highlight "Controls"
            {
                switch2.GetComponent<CanvasGroup>().alpha = 1.0F;
            }
            else
            {
                switch2.GetComponent<CanvasGroup>().alpha = 0.0F;
            }
        }
    }

    public void select()
    {
        if (state == 0) //select "retry"
        {
            pause_script.unPause();
            pause_script.isGameOver = false;
            Scene scene = SceneManager.GetActiveScene();

            SceneManager.LoadScene(scene.name);
        }

        else if (state == 1) //select "quit"
        {
            pause_script.unPause();
            pause_script.isGameOver = false;
            SceneManager.LoadSceneAsync("Main_Menu");


        }
    }
}
