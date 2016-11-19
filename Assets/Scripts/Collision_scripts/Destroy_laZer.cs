using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Destroy laZer
/*
/* DESCRIPTION: this is the descrution script for laZer projectiles that is essentially
/* 		identical to destroy bullet except it is not stopped by enemies.
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/

public class Destroy_laZer : MonoBehaviour {

	public Transform explosionPrefab;


	void OnCollisionEnter2D(Collision2D col) {
			
		if(col.gameObject.tag != "red_power_up" || col.gameObject.tag != "blue_power_up" || col.gameObject.tag != "yellow_power_up"){
			ContactPoint2D contact = col.contacts[0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			Vector3 pos = contact.point;
		//	Instantiate(explosionPrefab, pos, rot);
			//			Destroy(gameObject);
		}
	}
}
