using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/****************************************************************************************/
/*
/* FILE NAME: Main_Menu_Script
/*
/* DESCRIPTION: this script controls the behavior of the main menu
/*
/*
/* DATE     BY     			  DESCRIPTION
/* ======== ======= 		  =============
/* 11/24/16 Brandon           created script
/*
/****************************************************************************************/

public class Main_Menu_Script : MonoBehaviour {
    public int state = 0;
    private bool canScroll = true;
    public Canvas switch1;
    public Canvas switch2;
    public Canvas switch3;
    public Canvas controlsCanvas;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (((Input.GetKeyDown(KeyCode.A) || ((Input.GetAxis("Horizontal")) < 0 && canScroll))) && state > 0)
        {
            state--;
            canScroll = false;
        }
        else if (((Input.GetKeyDown(KeyCode.D) || ((Input.GetAxis("Horizontal")) > 0 && canScroll))) && state < 2)
        {
            state++;
            canScroll = false;
        }

        if (Input.GetAxis("Horizontal") == 0)
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
        if (state == 2) //Highlight "quit"
        {
            switch3.GetComponent<CanvasGroup>().alpha = 1.0F;
        }
        else
        {
            switch3.GetComponent<CanvasGroup>().alpha = 0.0F;
        }

        if (state == 1) //open controls on hover - over
        {
            controlsCanvas.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else
        {
            controlsCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        }
    }

    public void select()
    {
        if (state == 0) //select "start"
        {
            SceneManager.LoadSceneAsync("Test_Level");
        }

        else if (state == 2) //select "quit"
        {
            Application.Quit();

        }
    }
}
