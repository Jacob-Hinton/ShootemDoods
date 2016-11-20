using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: give power up
/*
/* DESCRIPTION: this is gives the player a power up and deletes the power up item when they
/*		collide.
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/

public class Give_Power_Up : MonoBehaviour {

	public Player_control pc;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			pc = col.gameObject.GetComponent<Player_control>();

			// ContactPoint2D contact = col.contacts[0];
			if(this.gameObject.tag == "red_power_up"){
				if(pc.held_power_ups.Count<=2){
					pc.held_power_ups.Push('r');
					Destroy(this.gameObject);
				}
			}
			// Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			// Vector3 pos = contact.point;
			// Instantiate(, pos, rot);
		}
	}
}
