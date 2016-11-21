using UnityEngine;
using System.Collections;

//****************************************************************************************/
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

public class Shoot_At_Player : MonoBehaviour {
	private float targetX;
	private float targetY;
	private Vector3 target;
	public float speed = 2.0F;

	// Use this for initialization
	void Start () {
		targetX = GameObject.FindWithTag ("Player").transform.position.x;
		targetY = GameObject.FindWithTag ("Player").transform.position.y;
		target = new Vector2 (targetX,targetY);
		target = transform.position + (target - transform.position).normalized * 1000.0f;
	}

	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, target, speed * Time.deltaTime);
//		transform.position = Vector2.MoveTowards(new Vector2(transform.position.x,transform.position.y),target,speed*Time.deltaTime);
	}
}