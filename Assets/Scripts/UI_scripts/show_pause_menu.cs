using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: show_pause_menu
/*
/* DESCRIPTION: this script controls the visibility of the pause menu
/*
/*
/* DATE     BY     			  DESCRIPTION
/* ======== ======= 		  =============
/* 11/23/26 Brandon           created script
/*
/****************************************************************************************/

public class show_pause_menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Camera").GetComponent<pause_script>().getIsPause()){
            gameObject.GetComponent<CanvasGroup>().alpha = 1f;
        }
        else
        {
            gameObject.GetComponent<CanvasGroup>().alpha = 0f;
        }
    }
}
