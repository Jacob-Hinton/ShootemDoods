using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/****************************************************************************************/
/*
/* FILE NAME: lives_display
/*
/* DESCRIPTION: this script polls the life_counter and updates the life display
 * 				ui element accordingly
/*
/*
/* DATE     BY     			  DESCRIPTION
/* ======== ======= 		  =============
/* 11/27/16 Jacob			  created script
/*
/****************************************************************************************/


public class lives_display : MonoBehaviour {

	public Sprite[] sprites = new Sprite[4];
	Image img;
	// Use this for initialization
	void Start () {
		img = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		img.sprite = sprites [life_counter.lives];
	}
}
