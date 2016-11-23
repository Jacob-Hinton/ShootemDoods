using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Destroy bullet
/*
/* DESCRIPTION: this script checks what a bullet collided with, and if its someone it can hurt,
/*		it does so. Regardless afterward the bullet explodes and is removed.
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/

public class Destroy_bullet : MonoBehaviour {

	
	public Transform explosionPrefab;


	void OnCollisionEnter2D(Collision2D col) {
			
//		if(col.gameObject.tag != "red_power_up" || col.gameObject.tag != "blue_power_up" || col.gameObject.tag != "yellow_power_up"){
//			ContactPoint2D contact = col.contacts[0];
//			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
//			Vector3 pos = contact.point;
//			Instantiate(explosionPrefab, pos, rot);
//			if(col.gameObject.tag == "red_enemy"){
//				col.gameObject.GetComponent<Spawn_powerup>().Spawn();
//				Destroy(col.gameObject);
//			}
//			Destroy(gameObject);
//		}
			ContactPoint2D contact = col.contacts[0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			Instantiate(explosionPrefab, pos, rot);
			Destroy(gameObject);
	}
}
