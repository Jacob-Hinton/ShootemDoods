using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: camera scrolling
/*
/* DESCRIPTION: this is the script that moves the camera at a fixed rate
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/

public class Camera_scrolling : MonoBehaviour {
	private float cameraScrollSpeed = Ambient_scrolling.ambientScrollSpeed;
	private Vector3 pos;
	private float space = Ambient_scrolling.ambientScrollSpace;
	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		pos.x += space;
		transform.position = Vector3.MoveTowards(transform.position, pos, cameraScrollSpeed * Time.deltaTime);
	}
}
