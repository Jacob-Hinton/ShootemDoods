using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Spawn_powerup
/*
/* DESCRIPTION: this script checks what type of enemy an enemy is (red, blue, yellow, neutral)
/* 		and spawns the appropiate power up.
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/

public class Spawn_powerup : MonoBehaviour {
	public Transform red_power_up;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Spawn(){
		if(gameObject.tag == "red_enemy"){
			Instantiate(red_power_up, transform.position, Quaternion.identity);
		}
	}
}
