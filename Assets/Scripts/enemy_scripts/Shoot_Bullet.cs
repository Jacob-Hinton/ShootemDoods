using UnityEngine;
using System.Collections;

//****************************************************************************************/
/*
/* FILE NAME: Shoot_Bullet
/*
/* DESCRIPTION: this script controls the behavior of an object which shoots bullets
/*
/*
/* DATE     BY     			  DESCRIPTION
/* ======== ======= 		  =============
/* 11/20/16 Brandon           created script + header
/*
/****************************************************************************************/

public class Shoot_Bullet : MonoBehaviour {

	private bool canShoot = false;
	private bool coRoutineIsStarted = false;
	public float pauseTime = 1.5f;
	public GameObject projectile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (canShoot) {
			GameObject clone;
			clone = Instantiate (projectile, transform.position + new Vector3 (0, 0, 0), transform.rotation) as GameObject;
			canShoot = false;
		} else if (!coRoutineIsStarted) {
			StartCoroutine (bulletWait ());
		}
	}

	public IEnumerator bulletWait() {
		coRoutineIsStarted = true;
		canShoot = false;
		yield return new WaitForSeconds (pauseTime);
		canShoot = true;
		coRoutineIsStarted = false;
	}
}
