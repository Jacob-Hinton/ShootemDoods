using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Enemy_Straight_Line
/*
/* DESCRIPTION: this script has enemies travel in straight lines across the screen
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/

public class Enemy_Straight_Line : MonoBehaviour {

	public float speed;
	public float space = 1.0F;
	public Vector3 pos;
    // Use this for initialization
    void Start () {
		pos = transform.position;
	}

	// FixedUpdate called at regular intervals
	void FixedUpdate () {

        //checks if the enemy is on the screen before executing their movement path
        if(GetComponent<Renderer>().isVisible)
        {
            //enemy movement path
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
	}

	float getX() {
		return transform.position.x;
	}

	float getY() {
		return transform.position.y;
	}


}