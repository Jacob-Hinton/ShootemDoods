using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Point_At_Player
/*
/* DESCRIPTION: this script controls the behavior of an object which must change it's angle to point at the player
/*
/*
/* DATE     BY     			  DESCRIPTION
/* ======== ======= 		  =============
/* 11/20/16 Brandon           created script + header
/*
/****************************************************************************************/

public class Point_At_Player : MonoBehaviour {
	private float target;
	public float speed = 50.0F;

	// Use this for initialization
	void Start () {
		target = Vector3.Angle (GameObject.FindWithTag("Player").transform.position, this.gameObject.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		float angle = Mathf.MoveTowardsAngle (transform.eulerAngles.y, target, speed * Time.deltaTime);
		transform.eulerAngles = new Vector3 (angle, 0, 0);
	}
}
