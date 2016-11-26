using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Bullet_fodder
/*
/* DESCRIPTION: this script checks if a fodder enemy with no health system is in contact
/* 		with a bullet and if so, explode it and delete it.
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/

public class Bullet_fodder : MonoBehaviour {
	public Transform explosionPrefab;


	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "player_bullet") {
			ContactPoint2D contact = col.contacts[0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			Instantiate(explosionPrefab, pos, rot);
			if(this.gameObject.tag == "red_enemy"){
				this.gameObject.GetComponent<Spawn_powerup>().Spawn();
			}
			Destroy(gameObject);
		}
	}
}
