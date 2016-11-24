using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/****************************************************************************************/
/*
/* FILE NAME: Pause_Menu
/*
/* DESCRIPTION: this script controls the behavior of the on-screen pause menu.
/*
/*
/* DATE     BY     			  DESCRIPTION
/* ======== ======= 		  =============
/* 11/23/26 Brandon           created script
/*
/****************************************************************************************/

public class Pause_Menu : MonoBehaviour {
    public Canvas controlsCanvas;
    public GameObject resSwitch;
    public GameObject controlSwitch;
    public GameObject quitSwitch;
    public Image switchImage1;
    public Image switchImage2;
    public Image switchImage3;
    public Sprite onSwitch;
    public Sprite offSwitch;
    private bool canScroll = true;
    public int state = 0;

    void Start()
    {
        resSwitch = GameObject.Find("Canvas/Pause Canvas/Pause_Menu/res_button");
        controlSwitch = GameObject.Find("Canvas/Pause Canvas/Pause_Menu/cont_button");
        quitSwitch = GameObject.Find("Canvas/Pause Canvas/Pause_Menu/quit_button");
        controlsCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        switchImage1 = resSwitch.GetComponent<Image>();
        switchImage2 = controlSwitch.GetComponent<Image>();
        switchImage3 = quitSwitch.GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Camera").GetComponent<pause_script>().getIsPause())
        {
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

            if((Input.GetKey(KeyCode.Space) || Input.GetButton("Fire1")))
            {
                select();
            }

            if (state == 0) //highlight "Resume"
            {
                switchImage1.sprite = onSwitch;
            }
            else
            {
                switchImage1.sprite = offSwitch;
            }
            if (state == 1) //Highlight "Controls"
            {
                switchImage2.sprite = onSwitch;
            }
            else
            {
                switchImage2.sprite = offSwitch;
            }
            if (state == 2) //Highlight "quit"
            {
                switchImage3.sprite = onSwitch;
            }
            else
            {
                switchImage3.sprite = offSwitch;
            }
        }
        else
        {
            controlsCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        }


    }


    public void select()
    {
        if (state == 0) //select "Resume"
        {
            pause_script.unPause();
        }
        else if (state == 1) //select "Controls"
        {
            controlsCanvas.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else //select "quit"
        {
            SceneManager.LoadScene("Main_Menu");
        }
    }
}
